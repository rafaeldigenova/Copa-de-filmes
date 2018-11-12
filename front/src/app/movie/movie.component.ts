import { Component, OnInit } from '@angular/core';
import { Movie } from '../movie';
import { MovieService } from '../movie.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.scss']
})
export class MovieComponent implements OnInit {
  selectedMoviesCount: number = 0;
  selectedMovies: Movie[] = [];
  movies: Movie[];
  loading: boolean = true;

  constructor(private movieService : MovieService, private router: Router) { }

  ngOnInit() {
    this.getMovies();
  }

  getMovies(): void {
    this.movieService.getMovies()
      .subscribe(movies => {
        this.loading = false;
        this.movies = movies
      });
  }

  onSubmit(): void {
    if(this.selectedMoviesCount != 8){
      alert("por favor, selecdione 8 filmes para começar o campeonato")

      return;
    }

    this.movieService.setSelectedMovies(this.selectedMovies);

    this.router.navigate(["/resultado"]);
  }

  onChange(movie: Movie): boolean {

    if(this.selectedMoviesCount == 8 && !movie.selecionado)
    {
      return false;
    }

    movie.selecionado = !movie.selecionado;

    if(movie.selecionado)
    {
      this.selectedMoviesCount++;
      this.selectedMovies.push(movie);
    } 
    else
    {
      this.selectedMoviesCount--;
      this.selectedMovies = this.selectedMovies.filter(arrMovie => movie.id != arrMovie.id);
    }

    return true;

  }

}
