using System.Threading.Tasks;

namespace JitHome.Persistence.Contracts
{
    public interface IGlobalPersist
    {

        void Incluir<T>(T entity) where T : class;
        void Alterar<T>(T entity) where T : class;
        void Excluir<T>(T entity) where T : class;
        void ExcluirIntervalo<T>(T[] entity) where T : class;
        Task<bool> SalvarAlteracoesAsync();
    }

}