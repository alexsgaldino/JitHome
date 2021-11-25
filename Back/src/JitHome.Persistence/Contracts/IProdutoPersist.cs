using System.Threading.Tasks;
using JitHome.Domain.Models;

namespace JitHome.Persistence.Contracts
{
    public interface IProdutoPersist : IGlobalPersist
    {
        Task<Produto[]> RecuperarProdutosPorNomeAsync(int userId, string nome);
        Task<Produto> RecuperarProdutoPorCodigoBarrasAsync(int userId, string codigoBarras);
        Task<Produto[]> RecuperarProdutosAsync(int userId);
        Task<Produto> RecuperarProdutoPorIdAsync(int userId, int id);
         
    }
}