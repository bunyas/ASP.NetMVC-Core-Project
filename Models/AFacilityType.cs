using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AFacilityType
    {
        public AFacilityType()
        {
            AFacilities = new HashSet<AFacilities>();
        }

        public string FacilityTypeId { get; set; }
        public string FacilityType { get; set; }

        public virtual ICollection<AFacilities> AFacilities { get; set; }
    }
}
