import { User } from "./Identity/User";

export interface Endereco {
  id: number;
  userId: number;
  user: User;
  CEP: string;
  rua: string;
  numero: string;
  dataCadastro?: Date;
  bairro: string;
  cidade: string;
  UF: string;
}
