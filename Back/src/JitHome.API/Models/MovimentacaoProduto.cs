using System;

namespace JitResidencial.Domain.Models
{
    public class MovimentacaoProduto
    
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public string DataMovimento { get; set; }
        public int QuantidadeEntrada { get; set; }
        public int QuantidadeSaida { get; set; }
    }
}