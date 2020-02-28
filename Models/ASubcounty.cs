using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ASubcounty
    {
        public ASubcounty()
        {
            AParish = new HashSet<AParish>();
        }

        public string SubcountyId { get; set; }
        public string CountyId { get; set; }
        public string SubcountyName { get; set; }
        public string SubcountyMinistryCode { get; set; }

        public virtual ACounty County { get; set; }
        public virtual ICollection<AParish> AParish { get; set; }
    }
}
