using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AProductType
    {
        public AProductType()
        {
            AProduct = new HashSet<AProduct>();
        }

        public int ProductTypeId { get; set; }
        public string ProductType { get; set; }

        public virtual ICollection<AProduct> AProduct { get; set; }
    }
}
