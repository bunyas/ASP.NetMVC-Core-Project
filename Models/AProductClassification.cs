using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AProductClassification
    {
        public AProductClassification()
        {
            AProduct = new HashSet<AProduct>();
        }

        public int Id { get; set; }
        public string ProductType { get; set; }
        public string Classification { get; set; }

        public virtual ICollection<AProduct> AProduct { get; set; }
    }
}
