using JitHome.Persistence.Contracts;
using JitHome.Persistence.Contexts;
using System.Threading.Tasks;
using System.Linq;
using JitHome.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace JitHome.Persistence.Implements
{
    public class ProdutoPersist : GlobalPersist, IProdutoPersist
    {
        private readonly JitHomeContext _context;
        public ProdutoPersist(JitHomeContext context) : base(context)
        {
            _context = context;

        }
        public async Task<Produto[]> RecuperarProdutosAsync(int userId)
        {
            IQueryable<Produto> query = _context.Produtos
                .Include(p => p.MovimentacoesProdutos )
                .Include(p => p.Estoques)
                .Include(p => p.ListasPrecos);

            query = query.AsNoTracking().Where(p => p.UserId == userId).OrderBy(p => p.Id);

            return await query.ToArrayAsync();
        }
        public async Task<Produto> RecuperarProdutoPorCodigoBarrasAsync(int userId, string codigoBarras)
        {
            IQueryable<Produto> query = _context.Produtos
                .Include(p => p.MovimentacoesProdutos)
                .Include(p => p.Estoques)
                .Include(p => p.ListasPrecos);

            query = query.AsNoTracking().OrderBy(p => p.CodigoBarras)
                    .Where(p => p.CodigoBarras
                        .ToLower()
                        .Contains(codigoBarras.ToLower()) && p.UserId == userId);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<Produto[]> RecuperarProdutosPorNomeAsync(int userId, string nome)
        {
            IQueryable<Produto> query = _context.Produtos
                .Include(p => p.MovimentacoesProdutos)
                .Include(p => p.Estoques)
                .Include(p => p.ListasPrecos);

            query = query.AsNoTracking().OrderBy(p => p.NomeProduto)
                    .Where(p => p.NomeProduto
                        .ToLower()
                        .Contains(nome.ToLower()) && p.UserId == userId);

            return await query.ToArrayAsync();
        }
        public async Task<Produto> RecuperarProdutoPorIdAsync(int userId, int id)
        {
            IQueryable<Produto> query = _context.Produtos
                .Include(p => p.MovimentacoesProdutos)
                .Include(p => p.Estoques)
                .Include(p => p.ListasPrecos);

            query = query.AsNoTracking().OrderBy(p => p.Id)
                    .Where(p => p.Id == id && p.UserId == userId);

            return await query.FirstOrDefaultAsync();
        }
    }
}