using System.Threading.Tasks;
using JitHome.Domain.Models;
using JitHome.Persistence.Contracts;

namespace JitHome.Persistence.Contratos
{
    public interface IListaPrecoPersist : IGlobalPersist
    {
        Task<ListaPreco> RecuperarListaPrecoPorIdAsync(int id);
        Task<ListaPreco[]> RecuperarListaPrecosPorProdutoAsync(int produtoId);
        Task<ListaPreco[]> RecuperarListaPrecosPorFornecedorProdutoAsync(int fornecedorId, int produtoId);
    }
}