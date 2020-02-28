using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AParish
    {
        public AParish()
        {
            AVillage = new HashSet<AVillage>();
        }

        public string ParishId { get; set; }
        public string ParishName { get; set; }
        public string SubcountyId { get; set; }
        public string ParishMinistryCode { get; set; }

        public virtual ASubcounty Subcounty { get; set; }
        public virtual ICollection<AVillage> AVillage { get; set; }
    }
}
