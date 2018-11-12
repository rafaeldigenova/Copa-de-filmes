import { Movie } from './movie';
import { PodiumMovie } from './podiumMovie';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import {
  map,
  debounceTime,
  distinctUntilChanged,
  switchMap,
  tap
} from "rxjs/operators";

@Injectable({
  providedIn: 'root'
})

export class MovieService {
  selectedMovies: Movie[] = [];

  private moviesUrl = '/api/filmes';
  private championshipUrl = '/teste/championship';

  constructor(private http : HttpClient) { }

  getMovies(): Observable<Movie[]> {
     return this.http.get<Movie[]>(this.moviesUrl);
  }

  setSelectedMovies(selectedMovies: Movie[]) : void{
    this.selectedMovies = selectedMovies;
  }

  getSelectedMovies() : Movie[] {
    return this.selectedMovies;
  }

  runChampionship(movies: Movie[]) : Observable<PodiumMovie[]> {
    return this.http.post<PodiumMovie[]>(this.championshipUrl, JSON.stringify(movies), {headers:{'Content-Type': 'application/json'}});
  }
}
