import { Fornecedor } from "./Fornecedor";

export interface ListaPreco {
  id: number;
  produtoId: number;
  precoUnitario: number;
  fornecedorId: number;
  fornecedor: Fornecedor;
  dataLosta?: Date;
}
