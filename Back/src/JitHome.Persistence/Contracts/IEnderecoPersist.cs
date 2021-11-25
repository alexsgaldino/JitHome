using System.Threading.Tasks;
using JitHome.Domain.Models;
using JitHome.Persistence.Contracts;

namespace JitHome.Persistence.Contratos
{
    public interface IEnderecoPersist : IGlobalPersist
    {
        Task<Endereco> GetEnderecoByIdAsync(int userId, int enderecoId);
    }
}