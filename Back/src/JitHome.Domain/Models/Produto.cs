using System;
using System.Collections.Generic;
using JitHome.Domain.Models.Enum;
using JitHome.Domain.Models.Identity;

namespace JitHome.Domain.Models
{
    public class Produto

    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string CodigoBarras { get; set; }
        public string NomeProduto { get; set; }
        public string Volume { get; set; }
        public DateTime DataValidade { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public Categoria Categoria { get; set; }
        public string ImagemURL { get; set; }
        public IEnumerable<MovimentacaoProduto> MovimentacoesProdutos { get; set; }
        public Estoque Estoques { get; set; }
        public IEnumerable<ListaPreco> ListasPrecos { get; set; }
    }
}
