using System.Linq;
using System.Threading.Tasks;
using JitHome.Domain.Models;
using JitHome.Persistence.Contexts;
using JitHome.Persistence.Contratos;
using Microsoft.EntityFrameworkCore;

namespace JitHome.Persistence.Implements
{
    public class FornecedorPersistt : GlobalPersist, IFornecedorPersist
    {
        private readonly JitHomeContext _context;
        public FornecedorPersistt(JitHomeContext context) : base(context)
        {
            _context = context;

        }
        public async Task<Fornecedor[]> RecuperarFornecedoresAsync()
        {
            IQueryable<Fornecedor> query = _context.Fornecedores;

            query = query.AsNoTracking().OrderBy(f => f.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Fornecedor[]> RecuperarFornecedoresPorNomeAsync(string nome)
        {
            IQueryable<Fornecedor> query = _context.Fornecedores;

            query = query.AsNoTracking().OrderBy(f => f.Nome)
                    .Where(f => f.Nome
                        .ToLower()
                        .Contains(nome.ToLower()));

            return await query.ToArrayAsync();
        }
        public async Task<Fornecedor> RecuperarFornecedorPorIdAsync(int id)
        {
            IQueryable<Fornecedor> query = _context.Fornecedores;

            query = query.AsNoTracking().OrderBy(f => f.Id)
                    .Where(f => f.Id == id);

            return await query.FirstOrDefaultAsync();
        }
    }
}