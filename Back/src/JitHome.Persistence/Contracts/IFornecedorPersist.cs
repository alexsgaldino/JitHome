using System;
using System.Threading.Tasks;
using JitHome.Domain.Models;
using JitHome.Persistence.Contracts;

namespace JitHome.Persistence.Contratos
{
    public interface IFornecedorPersist : IGlobalPersist
    {
        Task<Fornecedor[]> RecuperarFornecedoresPorNomeAsync(string nome);
        Task<Fornecedor[]> RecuperarFornecedoresAsync();

        Task<Fornecedor> RecuperarFornecedorPorIdAsync(int id);
    }
}