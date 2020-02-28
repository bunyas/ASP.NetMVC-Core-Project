using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssMPam
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public string DistrictName { get; set; }
        public string LevelDesc { get; set; }
        public string Cdcregion { get; set; }
        public string ComprehensiveImplimentingPartnerDescription { get; set; }
        public string Scto { get; set; }
        public int? UnderStock { get; set; }
        public int? OverStock { get; set; }
        public int? RightStock { get; set; }
        public int? StockedOut { get; set; }
        public int? Redistribution { get; set; }
        public int? Total { get; set; }
    }
}
