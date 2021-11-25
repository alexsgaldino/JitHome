using System.Collections.Generic;
using System.Threading.Tasks;
using JitHome.Domain.Models.Identity;
using JitHome.Persistence.Contracts;
using Microsoft.EntityFrameworkCore;

namespace JitHome.Persistence.Implements
{
    public class ContaPersist : GlobalPersist, IContaPersist
    {
        private readonly ContaPersist _context;
        public ContaPersist(ContaPersist context): base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<User>> RecuperarContasAsync()
        {
            return await _context.Users.ToListAsync();
        }
        public async Task<User> RecuperarContaPorIdAsync(int id)
        {
            return await _context.Users
                                 .FindAsync(id);
        }
        public async Task<User> RecuperarContaPorContaAsync(string conta)
        {
            return await _context.Users
                                 .FirstOrDefaultAsync(
                                     user => user.UserName == conta.ToLower());
        }

    }
}