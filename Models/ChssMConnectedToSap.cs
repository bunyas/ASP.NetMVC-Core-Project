using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssMConnectedToSap
    {
        public DateTime DateOfVisit { get; set; }
        public int FacilityCode { get; set; }
        public string Facility { get; set; }
        public int? DistrrictCode { get; set; }
        public string DistrictName { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public string ZoneDescription { get; set; }
        public int LevelOfCareCode { get; set; }
        public string LevelOfCare { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public int? ComprehensiveImplimentingPartnerCode { get; set; }
        public string ComprehensiveImplimentingPartnerDesc { get; set; }
        public string Scto { get; set; }
        public bool? ConnectedToSap { get; set; }
        public int? FacilityCount { get; set; }
    }
}
