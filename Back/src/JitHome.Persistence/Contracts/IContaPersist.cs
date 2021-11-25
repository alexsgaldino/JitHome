using System.Collections.Generic;
using System.Threading.Tasks;
using JitHome.Domain.Models.Identity;

namespace JitHome.Persistence.Contracts
{
    public interface IContaPersist : IGlobalPersist
    {
        Task<IEnumerable<User>> RecuperarContasAsync();
        Task<User> RecuperarContaPorIdAsync(int id);     
        Task<User> RecuperarContaPorContaAsync(string conta);
    }
}