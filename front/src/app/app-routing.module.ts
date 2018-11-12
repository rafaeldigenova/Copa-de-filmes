import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ResultadoComponent } from './resultado/resultado.component';
import { SelecaoComponent } from './selecao/selecao.component';

const routes: Routes = [
  { path: '', redirectTo: '/selecao', pathMatch: 'full' },
  { path: 'selecao', component: SelecaoComponent },
  { path: 'resultado', component: ResultadoComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
