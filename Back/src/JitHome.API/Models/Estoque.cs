using System;
using JitResidencial.Domain.Identity;

namespace JitResidencial.Domain.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string DataSaldo { get; set; }
        public int SaldoInicial { get; set; }
        public int QauntidadeMovimentada { get; set; }
        public int EstoqueFinal { get; set; }
        public int EstoqueDisponivel { get; set; }
    }
}