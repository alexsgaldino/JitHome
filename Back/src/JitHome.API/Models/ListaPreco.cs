using System;
using System.Collections.Generic;

namespace JitResidencial.Domain.Models
{
    public class ListaPreco
    {
        public int Id { get; set; }
        public int PrecoUnitario { get; set; }
        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int ProdutoId { get; set; }
        public string DataLista { get; set; }

    }
}