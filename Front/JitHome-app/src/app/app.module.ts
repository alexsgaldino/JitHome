import { BrowserAnimationsModule }  from '@angular/platform-browser/animations';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule,
         ReactiveFormsModule }      from '@angular/forms';
import { HttpClientModule }         from '@angular/common/http';
import { NgModule }                 from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent }     from './app.component';

import { CollapseModule } from 'ngx-bootstrap/collapse';

import { EstoquesComponent }      from './components/estoque/estoques/estoques.component';
import { ListaProdutosComponent } from './components/produto/lista/listaProdutos.component';
import { NavComponent }           from './shared/nav/nav.component';
import { TituloComponent }        from './shared/titulo/titulo.component';

@NgModule({
  declarations: [
    AppComponent,
    EstoquesComponent,
    ListaProdutosComponent,
    NavComponent,
    TituloComponent
  ],
  imports: [
    AppRoutingModule,
    BrowserAnimationsModule,
    BrowserModule,
    CollapseModule.forRoot(),
    FormsModule,
    HttpClientModule,

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
