using System;

namespace JitHome.Domain.Models
{
    public class MovimentacaoProduto
    
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public DateTime DataMovimento { get; set; }
        public decimal QuantidadeEntrada { get; set; }
        public decimal QuantidadeSaida { get; set; }
    }
}