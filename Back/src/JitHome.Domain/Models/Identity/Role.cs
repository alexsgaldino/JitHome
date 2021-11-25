using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace JitHome.Domain.Models.Identity
{
    public class Role: IdentityRole<int>
    {
        public IEnumerable<UserRole> UserRoles { get; set; }
    }
}