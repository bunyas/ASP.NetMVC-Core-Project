using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssMLocation
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public string ZoneDescription { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public string LevelOfCare { get; set; }
        public string DistrictName { get; set; }
        public string Cdcregion { get; set; }
        public string Scto { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string StartPlace { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public double? EndLong { get; set; }
        public double? EndLat { get; set; }
        public string EndPlace { get; set; }
    }
}
