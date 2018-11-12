import { Component, OnInit } from '@angular/core';
import { HeaderModel } from '../headerModel';

@Component({
  selector: 'app-resultado',
  templateUrl: './resultado.component.html',
  styleUrls: ['./resultado.component.scss']
})
export class ResultadoComponent implements OnInit {

  headerModel: HeaderModel = {
    titulo: "Resultado Final",
    descricao: "Veja o resultado final do Campeonato de filmes de forma simples e rápida"  
  };

  constructor() { }

  ngOnInit() {
  }

}
