using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewFacilityGisCodinates
    {
        public int FacilityCode { get; set; }
        public string ZoneDescription { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public string DistrictName { get; set; }
        public string Cdcregion { get; set; }
        public string LevelOfCare { get; set; }
        public string ClientTypeDesc { get; set; }
        public string FacilityType { get; set; }
        public string OwnershipDescription { get; set; }
        public string Facility { get; set; }
        public string SapCode { get; set; }
        public string Longtitude { get; set; }
        public string Latititude { get; set; }
        public int? OldSector { get; set; }
        public int? NewSector { get; set; }
    }
}
