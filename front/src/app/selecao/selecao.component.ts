import { Component, OnInit } from '@angular/core';
import { HeaderModel } from '../headerModel';

@Component({
  selector: 'app-selecao',
  templateUrl: './selecao.component.html',
  styleUrls: ['./selecao.component.scss']
})
export class SelecaoComponent implements OnInit {

  headerModel: HeaderModel = {
    titulo: "Fase de Seleção",
    descricao: "Selecione 8 filmes que você deseja que entrem na competição e depois pressione o botão Gerar Meu Campeonato para prosseguir"  
  };

  constructor() { }

  ngOnInit() {
  }

}
