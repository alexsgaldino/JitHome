using System;

namespace JitHome.Domain.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public DateTime DataSaldo { get; set; }
        public int SaldoInicial { get; set; }
        public decimal QauntidadeMovimentada { get; set; }
        public decimal EstoqueFinal { get; set; }
        public decimal EstoqueDisponivel { get; set; }
    }
}