/* ---------------------- ANGULAR IMPORTS ---------------------- */
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CommonModule } from '@angular/common';
import {
  FormsModule,
         ReactiveFormsModule }      from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';

/* ---------------------- BOOTSTRAP IMPORTS ---------------------- */
import { BrowserModule } from '@angular/platform-browser';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { CollapseModule } from 'ngx-bootstrap/collapse';
import { ModalModule } from 'ngx-bootstrap/modal';
import { NgxSpinnerModule } from 'ngx-spinner';
import { ToastrModule } from 'ngx-toastr';
import { TooltipModule } from 'ngx-bootstrap/tooltip';


import {BsDatepickerModule}         from 'ngx-bootstrap/datepicker';



/* ---------------------- Services IMPORTS ---------------------- */
import { ProdutoService } from './Services/produto/produto.service';

/* ---------------------- SUPPORT IMPORTS ---------------------- */
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';

/* ---------------------- HELPERS IMPORTS ---------------------- */
import { DateTimeFormatPipe } from './helpers/DateTimeFormat.pipe';

/* ---------------------- COMPONENTS IMPORTS ---------------------- */
import { EstoqueComponent } from './components/estoque/estoque.component';
import { EnderecoComponent } from './components/user/endereco/endereco.component';
import { FornecedorComponent } from './components/fornecedor/fornecedor.component';
import { ListaPrecoComponent } from './components/listaPreco/listaPreco.component';
import { ListaProdutosComponent } from './components/produto/lista/listaProdutos.component';
import { MovimentacaoProdutoComponent } from './components/movimentacaoProduto/movimentacaoProduto.component';
import { NavComponent } from './shared/nav/nav.component';
import { TituloComponent } from './shared/titulo/titulo.component';
import { UserComponent } from './components/user/account/user/user.component';


@NgModule({
  declarations: [
    AppComponent,
    DateTimeFormatPipe,
    EnderecoComponent,
    EstoqueComponent,
    FornecedorComponent,
    ListaPrecoComponent,
    ListaProdutosComponent,
    MovimentacaoProdutoComponent,
    NavComponent,
    TituloComponent,
    UserComponent
  ],
  imports: [
    AppRoutingModule,
    BrowserAnimationsModule,
    BrowserModule,
    BsDropdownModule.forRoot(),
    CollapseModule.forRoot(),
    FormsModule,
    HttpClientModule,
    ModalModule.forRoot(),
    NgxSpinnerModule,
    ToastrModule.forRoot({
      timeOut: 3000,
      positionClass: 'toast-top-right',
      preventDuplicates: true,
      progressBar: true,
    }),
    TooltipModule.forRoot(),
  ],
  providers: [ProdutoService],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  bootstrap: [AppComponent]
})
export class AppModule { }
