using System.Threading.Tasks;
using JitHome.Application.Dtos;

namespace JitHome.Application.Contracts
{
    public interface ITokenService
    {
        Task<string> CreateToken(AlterarContaDto alterarContaDto);
    }
}