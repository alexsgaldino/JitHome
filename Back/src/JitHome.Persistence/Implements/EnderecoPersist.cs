using System.Linq;
using System.Threading.Tasks;
using JitHome.Persistence.Contratos;
using Microsoft.EntityFrameworkCore;
using JitHome.Persistence.Contexts;
using JitHome.Domain.Models;

namespace JitHome.Persistence.Implements
{
    public class EnderecoPersist : GlobalPersist, IEnderecoPersist
    {
        private readonly JitHomeContext _context;
        public EnderecoPersist(JitHomeContext context) : base(context)
        {
            _context = context;

        }
        public async Task<Endereco> GetEnderecoByIdAsync(int userId, int id)
        {
            IQueryable<Endereco> query = _context.Enderecos;

            query = query.AsNoTracking().OrderBy(en => en.Id)
                    .Where((en => en.Id == id && en.UserId == userId));

            return await query.FirstOrDefaultAsync();
        }  

    }
}