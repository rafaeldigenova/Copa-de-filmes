import { Component, OnInit, Input } from '@angular/core';
import { HeaderModel } from '../headerModel';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  @Input() headerModel: HeaderModel;

  // headerModel: HeaderModel = {
  //   titulo: "Fase de Seleção",
  //   descricao: "Selecione 8 filmes que você deseja que entrem na competição e depois pressione o botão Gerar Meu Campeonato para prosseguir"  
  // };

  constructor() { }

  ngOnInit() {
  }

}
