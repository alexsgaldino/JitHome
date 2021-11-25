using JitHome.Domain.Models;
using JitHome.Application.Dtos;
using JitHome.Domain.Models.Identity;

namespace JitHome.Application.Helpers
{
    public class JitHomeProfile : Profile
    {
        public JitHomeProfile()
        {
            CreateMap<Produto, ProdutoDto>().ReverseMap();
            
            CreateMap<User, ContaDto>().ReverseMap();
            CreateMap<User, ContaLoginDto>().ReverseMap();
            CreateMap<User, AlterarContaDto>().ReverseMap();
        }
    }
}