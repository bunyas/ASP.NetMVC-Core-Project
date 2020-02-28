using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssViewFacilities
    {
        public int FacilityCode { get; set; }
        public string Facility { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public int LevelOfCareCode { get; set; }
        public string LevelOfCare { get; set; }
        public bool? SupportedByMaul { get; set; }
        public bool? IsAccredited { get; set; }
        public int? OwnershipId { get; set; }
        public int? RegionCode { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public int? DistrrictCode { get; set; }
        public string DistrictName { get; set; }
        public string RegionId { get; set; }
        public string RegionDescription { get; set; }
    }
}
