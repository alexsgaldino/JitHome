import { ListaPreco } from "./ListaPreco";

export interface Fornecedor {
  id: number;
  listaPreco: ListaPreco;
  CNPJ: string;
  nome: string;
  nomeFantasia: string;
  dataInclusao?: Date;
}
