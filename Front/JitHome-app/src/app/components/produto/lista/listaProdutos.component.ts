import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-listaProdutos',
  templateUrl: './listaProdutos.component.html',
  styleUrls: ['./listaProdutos.component.scss']
})
export class ListaProdutosComponent implements OnInit {

  public produtos: any = [];
  public produtosFiltrados: any = [];

  larguraImagem = 70;
  alturaImagem = 110;
  margemImagem = 2;
  exibirImagem = true;

  private _filtroLista = '';

  public get filtroLista(): string {
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.produtosFiltrados = this.filtroLista ? this.filtrarProdutos(this.filtroLista) : this.produtos;
  }

  filtrarProdutos(filtrarPor: string): any {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.produtos.filter(
      (produto: any) => produto.nomeProduto.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
        produto.volume.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );
  }
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.recuperarProdutos();
  }

  public recuperarProdutos(): void {
    this.http.get('https://localhost:5001/api/produtos').subscribe(
      response => {
        this.produtos = response;
        this.produtosFiltrados = this.produtos;
      },
      error => console.log(error)

      );
  }

  recolherImagem() {
    this.exibirImagem = !this.exibirImagem;
  }

}
