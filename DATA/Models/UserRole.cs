using Microsoft.AspNetCore.Identity;

namespace DATA.Models
{
    public partial class UserRole: IdentityUserRole<int>
    {
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
