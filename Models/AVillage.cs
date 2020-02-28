using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AVillage
    {
        public AVillage()
        {
            AFacilities = new HashSet<AFacilities>();
        }

        public string VillageId { get; set; }
        public string VillageName { get; set; }
        public string ParishId { get; set; }
        public string VillageMinistryCode { get; set; }

        public virtual AParish Parish { get; set; }
        public virtual ICollection<AFacilities> AFacilities { get; set; }
    }
}
