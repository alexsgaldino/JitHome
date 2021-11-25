using System.Collections.Generic;
using JitHome.Domain.Models.Enum;
using Microsoft.AspNetCore.Identity;

namespace JitHome.Domain.Models.Identity
{
    public class User : IdentityUser<int>
    {
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public string ImagemURL { get; set; }
        public string SobreMim { get; set; }
        public IEnumerable<UserRole> UserRoles { get; set; }
        public string Password { get; set; }
        public Grupo Grupo { get; set; }
    }
}