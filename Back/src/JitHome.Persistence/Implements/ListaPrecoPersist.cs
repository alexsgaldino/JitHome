using System.Linq;
using System.Threading.Tasks;
using JitHome.Domain.Models;
using JitHome.Persistence.Contexts;
using JitHome.Persistence.Contratos;
using Microsoft.EntityFrameworkCore;

namespace JitHome.Persistence.Implements
{
    public class ListaPrecoPersist : GlobalPersist, IListaPrecoPersist
    {
        private readonly JitHomeContext _context;
        public ListaPrecoPersist(JitHomeContext context) : base(context)
        {
            _context = context;

        }
        public async Task<ListaPreco> RecuperarListaPrecoPorIdAsync(int id)
        {
            IQueryable<ListaPreco> query = _context.ListasPrecos;

            query = query.AsNoTracking().OrderBy(lp => lp.Id)
                    .Where(lp => lp.Id == id);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<ListaPreco[]> RecuperarListaPrecosPorProdutoAsync(int produtoId)
        {
            IQueryable<ListaPreco> query = _context.ListasPrecos;

            query = query.AsNoTracking().OrderBy(lp => lp.Id)
                    .Where(lp => lp.ProdutoId == produtoId);

            return await query.ToArrayAsync(); 
        }
        public async Task<ListaPreco[]> RecuperarListaPrecosPorFornecedorProdutoAsync(int fornecedorId, int produtoId)
        {
            IQueryable<ListaPreco> query = _context.ListasPrecos;

            query = query.AsNoTracking().OrderBy(lp => lp.Id)
                    .Where(lp => lp.Id == fornecedorId || lp.ProdutoId == produtoId);

            return await query.ToArrayAsync();
        }
    }
}