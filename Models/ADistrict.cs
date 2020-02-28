using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ADistrict
    {
        public ADistrict()
        {
            ACounty = new HashSet<ACounty>();
            AFacilities = new HashSet<AFacilities>();
        }

        public int DistrictCode { get; set; }
        public string DistrictName { get; set; }
        public string RegionId { get; set; }
        public bool? IsUrban { get; set; }
        public string DistrictMinistryCode { get; set; }
        public bool? IsMunicipality { get; set; }
        public string IsoCode { get; set; }
        public int? CdcregionId { get; set; }
        public int? ImplimentingPartnerCode { get; set; }

        public virtual ACdcregion Cdcregion { get; set; }
        public virtual AImplimentingPartners ImplimentingPartnerCodeNavigation { get; set; }
        public virtual ARegion Region { get; set; }
        public virtual ICollection<ACounty> ACounty { get; set; }
        public virtual ICollection<AFacilities> AFacilities { get; set; }
    }
}
