using System.Net.Http.Headers;
using System;
using System.Collections.Generic;

namespace JitHome.Domain.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public int ListaPrecoId { get; set; }
        public ListaPreco ListaPreco { get; set; }
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public DateTime? DataCadastro { get; set; }
    

    }
}