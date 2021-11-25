using System;
using System.Collections.Generic;

namespace JitHome.Domain.Models
{
    public class ListaPreco
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int PrecoUnitario { get; set; }
        public int FonrecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public DateTime? DataLista { get; set; }

    }
}