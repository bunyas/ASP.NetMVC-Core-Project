using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDashExpectedVisits
    {
        public int FacilityCode { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public string Cdcregion { get; set; }
        public string DistrictName { get; set; }
        public string ZoneDescription { get; set; }
        public string LevelOfCare { get; set; }
        public string Scto { get; set; }
        public DateTime DateOfVisit { get; set; }
        public DateTime? NextPlannedVisit { get; set; }
        public int? VisitNo { get; set; }
        public int? ActualVisits { get; set; }
    }
}
