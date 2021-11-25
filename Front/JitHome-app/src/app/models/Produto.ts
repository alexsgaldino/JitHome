import { Estoque } from "./Estoque";
import { User } from "./Identity/User";
import { ListaPreco } from "./ListaPreco";
import { MovimentacaoProduto } from "./MovimentacaoProduto";

export interface Produto {

  id: number;
  userId: string;
  user: User;
  codigoBarras: string;
  nomeProduto:  string;
  volume:  string;
  dataValidade:  Date;
  dataInclusao?: Date;
  dataAlteracao:  Date;
  unidadeMedida: string;
  categoria: string;
  imsgemURL: string;
  movimentoId: number;
  movimentacoesProdutos: MovimentacaoProduto[];
  estoqueId: number;
  Estoques:  Estoque;
  listasPrecos: ListaPreco[];
}
