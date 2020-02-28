using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class UsersUserInformation
    {
        public UsersUserInformation()
        {
            OrderSmcHeaderAddedByNavigation = new HashSet<OrderSmcHeader>();
            OrderSmcHeaderEditedByNavigation = new HashSet<OrderSmcHeader>();
            UserMenuOption = new HashSet<UserMenuOption>();
            UsersUserRoles = new HashSet<UsersUserRoles>();
        }

        public short? District { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public short? GranteeId { get; set; }
        public short? IsActive { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Email { get; set; }

        public virtual ICollection<OrderSmcHeader> OrderSmcHeaderAddedByNavigation { get; set; }
        public virtual ICollection<OrderSmcHeader> OrderSmcHeaderEditedByNavigation { get; set; }
        public virtual ICollection<UserMenuOption> UserMenuOption { get; set; }
        public virtual ICollection<UsersUserRoles> UsersUserRoles { get; set; }
    }
}
