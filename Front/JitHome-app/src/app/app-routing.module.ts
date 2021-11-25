import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { EstoqueComponent } from './components/estoque/estoque.component';
import { FornecedorComponent } from './components/fornecedor/fornecedor.component';
import { HomeComponent } from './components/home/home.component';
import { ListaPrecoComponent } from './components/listaPreco/listaPreco.component';
import { MovimentacaoProdutoComponent } from './components/movimentacaoProduto/movimentacaoProduto.component';
import { ListaProdutosComponent } from './components/produto/lista/listaProdutos.component';
import { UserComponent } from './components/user/account/user/user.component';

const routes: Routes = [
  { path: 'produto', component: ListaProdutosComponent },
  { path: 'estoque', component: EstoqueComponent },
  { path: 'fornecedor', component: FornecedorComponent },
  { path: 'precos', component: ListaPrecoComponent },
  { path: 'movimento', component: MovimentacaoProdutoComponent },
  { path: 'home', component: HomeComponent },
  { path: 'conta', component: UserComponent },
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: '**', redirectTo: 'home', pathMatch: 'full' },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
