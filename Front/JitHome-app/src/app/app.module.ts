import { BrowserAnimationsModule }  from '@angular/platform-browser/animations';
import { BrowserModule }            from '@angular/platform-browser';
import { HttpClientModule }         from '@angular/common/http';
import { NgModule }                 from '@angular/core';

import { AppRoutingModule }   from './app-routing.module';
import { AppComponent }       from './app.component';

import { EstoquesComponent }  from './components/estoque/estoques/estoques.component';
import { ProdutosComponent }  from './components/produto/produtos/produtos.component';

@NgModule({
  declarations: [
    AppComponent,
    EstoquesComponent,
    ProdutosComponent
  ],
  imports: [
    AppRoutingModule,
    BrowserAnimationsModule,
    BrowserModule,
    HttpClientModule,

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
