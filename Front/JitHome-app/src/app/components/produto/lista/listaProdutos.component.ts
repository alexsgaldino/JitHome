import { Component, OnInit, TemplateRef } from '@angular/core';
import { Toastrservice } from '@angular/core'

import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { NgxSpinnerService } from "ngx-spinner";

import { Produto } from 'src/app/models/Produto';
import { ProdutoService } from 'src/app/Services/produto/produto.service';


@Component({
  selector: 'app-listaProdutos',
  templateUrl: './listaProdutos.component.html',
  styleUrls: ['./listaProdutos.component.scss']
})
export class ListaProdutosComponent implements OnInit {
  public modalRef: BsModalRef | undefined;

  public produtos: Produto[] = [];
  public produtosFiltrados: Produto[] = [];

  public larguraImagem = 70;
  public alturaImagem = 110;
  public margemImagem = 2;
  public exibirImagem = true;

  private _filtroLista = '';

  public get filtroLista(): string {
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.produtosFiltrados = this.filtroLista ? this.filtrarProdutos(this.filtroLista) : this.produtos;
  }

  public filtrarProdutos(filtrarPor: string): Produto[] {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.produtos.filter(
      (produto: any) => produto.nomeProduto.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
        produto.volume.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );
  }
  constructor(
    private produtoService: ProdutoService,
    private modalService: BsModalService,
    private toastr: ToastrService,
    private spinner: NgxSpinnerService
  ) { }

  public ngOnInit() {
    /** spinner starts on init */
    this.spinner.show();

    this.recuperarProdutos();
  }

  public recuperarProdutos(): void {
    this.produtoService.recuperarProdutos().subscribe({
      next: (produtos: Produto[]) => {
        this.produtos = produtos;
        this.produtosFiltrados = this.produtos;
      },
      error: (error: any) => this.toastr.error('Erro ao carregar profutos', 'Erro!')
    }).add(() => this.spinner.hide());
  }

  public recolherImagem(): void {
    this.exibirImagem = !this.exibirImagem;
  }

  public abrirModal(template: TemplateRef<any>): void {
    this.modalRef = this.modalService.show(template, { class: 'modal-sm' });
  }
  public confirmar(): void {
    this.modalRef?.hide();
    this.toastr.sucess("Registro excluído.", 'Excluído')
  }
  public recusar(): void {
    this.modalRef?.hide()
  }
}
