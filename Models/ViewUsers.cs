using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewUsers
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public short? IsActive { get; set; }
        public int RoleId { get; set; }
    }
}
