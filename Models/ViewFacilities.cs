using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewFacilities
    {
        public int FacilityCode { get; set; }
        public string Facility { get; set; }
        public string SapCode { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public string ZoneDescription { get; set; }
        public int? ComprehensiveImplimentingPartnerCode { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public int? DistrrictCode { get; set; }
        public string DistrictName { get; set; }
        public int? LevelOfCare { get; set; }
        public string LevelofCare1 { get; set; }
        public string RegionDescription { get; set; }
        public string RfsoUserName { get; set; }
        public int? CdcregionId { get; set; }
        public string Cdcregion { get; set; }
        public string FacilityTypeId { get; set; }
        public string FacilityType { get; set; }
        public string Longtitude { get; set; }
        public string Latititude { get; set; }
    }
}
