using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AFacilityLevelOfCare
    {
        public AFacilityLevelOfCare()
        {
            AFacilities = new HashSet<AFacilities>();
        }

        public int LevelOfCareCode { get; set; }
        public string LevelOfCare { get; set; }

        public virtual ICollection<AFacilities> AFacilities { get; set; }
    }
}
