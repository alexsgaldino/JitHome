using JitHome.Domain.Models.Identity;
using Microsoft.AspNetCore.Identity;

namespace JitHome.Domain.Models.Identity
{
    public class UserRole: IdentityUserRole<int>
    {
        public User User { get; set; }
        public Role Role { get; set; }
    }
}