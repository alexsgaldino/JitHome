using JitResidencial.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace JitHome.API.Data
{
    public class JitHomeContext :DbContext
    {
        public JitHomeContext(DbContextOptions<JitHomeContext> options) : base(options)
        {
            
        }
        public DbSet<Produto> Produtos { get; set; }
    }
}