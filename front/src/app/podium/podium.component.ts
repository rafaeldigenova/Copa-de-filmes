import { Component, OnInit } from '@angular/core';
import { PodiumMovie } from '../podiumMovie';
import { MovieService } from '../movie.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-podium',
  templateUrl: './podium.component.html',
  styleUrls: ['./podium.component.scss']
})
export class PodiumComponent implements OnInit {
  podiumMovies: PodiumMovie[];
  loading: boolean = true;

  constructor(private movieService : MovieService, private router: Router) { }

  ngOnInit() {
    this.getMovies();
  }

  getMovies(): void {
    var championshipMovies = this.movieService.getSelectedMovies();

    if(championshipMovies.length == 0){
      this.router.navigate(["/"]);
      return;       
    }

    this.movieService.runChampionship(championshipMovies)
      .subscribe(movies => {
        this.loading = false;
        this.podiumMovies = movies
      });
  }

  onBackPressed(): void {
    this.router.navigate(["/"]);
  }

}
