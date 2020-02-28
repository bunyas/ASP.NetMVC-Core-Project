using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class UsersUserRoles
    {
        public string UserId { get; set; }
        public int RoleId { get; set; }

        public virtual UsersRoles Role { get; set; }
        public virtual UsersUserInformation User { get; set; }
    }
}
