using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AUserType
    {
        public AUserType()
        {
            AspNetUsers1 = new HashSet<AspNetUsers1>();
        }

        public int UserTypeId { get; set; }
        public string UserType { get; set; }

        public virtual ICollection<AspNetUsers1> AspNetUsers1 { get; set; }
    }
}
