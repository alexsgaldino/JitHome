using System.Threading.Tasks;
using JitHome.Persistence.Contexts;
using JitHome.Persistence.Contracts;

namespace JitHome.Persistence.Implements
{
    public interface GlobalPersist
    {
        private readonly JitHomeContext _context;
        public GlobalPersist(JitHomeContext context)
        {
            _context = context;
            
        }
        public void Incluir<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Alterar<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Excluir<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void ExcluirIntervalo<T>(T[] entityArray) where T : class
        {
            _context.RemoveRange(entityArray);
        }
        public async Task<bool> SalvarAlteracoesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

    }
}