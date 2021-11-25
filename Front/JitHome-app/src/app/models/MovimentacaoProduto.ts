import { Produto } from "./Produto";

export interface MovimentacaoProduto {
  id: number;
  produtoId: number;
  produtos: Produto;
  dataMovimento?: Date;
  quantidadeEntrada: number;
  quantidadeSaida: number;
}
