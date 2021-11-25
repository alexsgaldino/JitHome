using JitHome.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace JitHome.Persistence.Contexts
{
    public class JitHomeContext :DbContext
    {
        public JitHomeContext(DbContextOptions<JitHomeContext> options) : base(options)
        {
            
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<MovimentacaoProduto> MovimentacoesProdutos { get; set; }
        public DbSet<ListaPreco> ListasPrecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

    }
}