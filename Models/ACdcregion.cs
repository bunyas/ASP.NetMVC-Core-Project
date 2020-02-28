using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ACdcregion
    {
        public ACdcregion()
        {
            ADistrict = new HashSet<ADistrict>();
            AFacilities = new HashSet<AFacilities>();
        }

        public int CdcregionId { get; set; }
        public string Cdcregion { get; set; }

        public virtual ICollection<ADistrict> ADistrict { get; set; }
        public virtual ICollection<AFacilities> AFacilities { get; set; }
    }
}
