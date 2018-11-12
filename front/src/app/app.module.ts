import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule, HttpClientJsonpModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { MovieComponent } from './movie/movie.component';
import { PodiumComponent } from './podium/podium.component';
import { SelecaoComponent } from './selecao/selecao.component';
import { ResultadoComponent } from './resultado/resultado.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    MovieComponent,
    PodiumComponent,
    SelecaoComponent,
    ResultadoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    HttpClientJsonpModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
