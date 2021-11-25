using System;
using System.Threading.Tasks;
using JitHome.Domain.Models;
using JitHome.Persistence.Contracts;

namespace JitHome.Persistence.Contratos
{
    public interface IMovimentacaoProdutoPersist : IGlobalPersist
    {
        Task<MovimentacaoProduto[]> RecuperarMovimentosAsync();
        Task<MovimentacaoProduto> RecuperarMovimentoPorIdAsync(int id);
        Task<MovimentacaoProduto[]> RecuperarMovimentosPorProdutoIdAsync(int produtoId);
        Task<MovimentacaoProduto[]> RecuperarMovimentosPorDataMovimentoAsync(DateTime dataMovimento);
    }
}