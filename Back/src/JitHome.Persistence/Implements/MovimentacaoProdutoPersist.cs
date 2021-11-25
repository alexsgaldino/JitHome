using System;
using System.Linq;
using System.Threading.Tasks;
using JitHome.Domain.Models;
using JitHome.Persistence.Contexts;
using JitHome.Persistence.Contratos;
using Microsoft.EntityFrameworkCore;

namespace JitHome.Persistence.Implements
{
    public class MovimentacaoProdutoPersist : GlobalPersist, IMovimentacaoProdutoPersist
    {
        private readonly JitHomeContext _context;
        public MovimentacaoProdutoPersist(JitHomeContext context) : base(context)
        {
            _context = context;

        }
         public async Task<MovimentacaoProduto[]>RecuperarMovimentosAsync()
        {
            IQueryable<MovimentacaoProduto> query = _context.MovimentacoesProdutos;

            query = query.OrderBy(m => m.Id);

            return await query.ToArrayAsync();
        }
        public async Task<MovimentacaoProduto> RecuperarMovimentoPorIdAsync(int id)
        {
            IQueryable<MovimentacaoProduto> query = _context.MovimentacoesProdutos;

            query = query.AsNoTracking().OrderBy(m => m.Id)
                    .Where(m => m.Id == id);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<MovimentacaoProduto[]> RecuperarMovimentosPorProdutoIdAsync(int produtoId)
        {
            IQueryable<MovimentacaoProduto> query = _context.MovimentacoesProdutos;

            query = query.AsNoTracking().OrderBy(m => m.ProdutoId)
                    .Where(m => m.ProdutoId == produtoId);

            return await query.ToArrayAsync();
        }
        public async Task<MovimentacaoProduto[]> RecuperarMovimentosPorDataMovimentoAsync(DateTime dataMovimento)
        {
            IQueryable<MovimentacaoProduto> query = _context.MovimentacoesProdutos;

            query = query.OrderBy(m => m.DataMovimento.ToString()
                                        .Contains(dataMovimento.ToString()));

            return await query.ToArrayAsync();
        }
    }
}