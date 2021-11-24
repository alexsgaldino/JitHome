import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-titulo',
  templateUrl: './titulo.component.html',
  styleUrls: ['./titulo.component.scss']
})
export class TituloComponent implements OnInit {
  @Input() titulo = "Padrão";
  @Input() iconClass = "fa fa-store";
  @Input() botaoListar = false;
  @Input() acao = "Cadastro"


  constructor(private router: Router) { }

  ngOnInit() {}
    listar(): void{
    this.router.navigate([`/${this.titulo.toLocaleLowerCase()}/list`]);
  }
}
