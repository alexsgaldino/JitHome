import { Produto } from "./Produto";

export interface Estoque {

  id: number;
  produtoId: number;
  produto: Produto;
  dataSaldo: Date;
  saldoInicial: number;
  quantidadeMovimentada: number;
  estoqueFinal: number;
  estoqueDisponivel: number;
}
