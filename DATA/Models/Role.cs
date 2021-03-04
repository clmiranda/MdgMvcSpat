using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Models
{
    public partial class Role: IdentityRole<int>
    {

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
