using System.Threading.Tasks;
using JitHome.Domain.Models;
using JitHome.Persistence.Contracts;

namespace JitHome.Persistence.Contratos
{
    public interface IEstoquePersist : IGlobalPersist
    {
        Task<Estoque> RecuperarEstoquePorIdAsync(int Id);

    }
}