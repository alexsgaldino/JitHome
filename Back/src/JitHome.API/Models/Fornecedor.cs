using System.Net.Http.Headers;
using System;
using System.Collections.Generic;

namespace JitResidencial.Domain.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string DataCadastro { get; set; }
    

    }
}