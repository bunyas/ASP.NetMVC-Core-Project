using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class UserMenuOption
    {
        public string UserName { get; set; }
        public string MenuItemType { get; set; }
        public string MenuItemKey { get; set; }
        public bool? MenuItemEnabled { get; set; }
        public bool? MenuItemVisible { get; set; }

        public virtual UsersUserInformation UserNameNavigation { get; set; }
    }
}
