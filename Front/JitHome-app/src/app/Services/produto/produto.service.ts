import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { Observable } from 'rxjs';
import { take } from 'rxjs/operators'
import { Produto } from 'src/app/models/Produto';
import { environment } from 'src/environments/environment';


@Injectable()
export class ProdutoService {

  baseURL = ' https://localhost:5001/api/produtos';

 // baseURL = `${environment.}api/produtos`
  constructor(private http: HttpClient) {

  }

  public recuperarProdutos(): Observable<Produto[]> {
    return this.http
      .get<Produto[]>(this.baseURL)
      .pipe(take(1));
  }

  public recuperarProdutoPorNomeProduto(nomeProduto: string): Observable<Produto[]> {
    return this.http
      .get<Produto[]>(`${this.baseURL}/{${nomeProduto}/nomeProduto`)
      .pipe(take(1));
  }

  public recuperarProdutoPorId(id: number): Observable<Produto> {
    return this.http
      .get<Produto>(`${this.baseURL}/${id}`)
      .pipe(take(1));
  }

  public publicarProdutos(produto: Produto): Observable<Produto> {
    return this.http
      .post<Produto>(this.baseURL, produto)
      .pipe(take(1));
  }

  public salvaProduto(produto: Produto): Observable<Produto> {
    return this.http
      .put<Produto>(`${this.baseURL}/${produto.id}`, produto)
      .pipe(take(1));
  }

  public excluirProduto(id: number): Observable<any> {
    return this.http
      .delete(`${this.baseURL}/${id}`)
      .pipe(take(1));
  }
}

