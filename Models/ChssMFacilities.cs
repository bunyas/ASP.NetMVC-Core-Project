using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssMFacilities
    {
        public int FacilityCode { get; set; }
        public string SapCode { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public string ImplimentingPartnerDescription { get; set; }
        public int? DistrrictCode { get; set; }
        public string DistrictName { get; set; }
        public int? LevelOfCare { get; set; }
        public string LevelDesc { get; set; }
        public int? CdcregionId { get; set; }
        public string Cdcregion { get; set; }
        public int? ComprehensiveImplimentingPartnerCode { get; set; }
        public string ComprehensiveImplimentingPartnerDescription { get; set; }
        public string Scto { get; set; }
        public string Facility { get; set; }
        public bool? IsActive { get; set; }
    }
}
