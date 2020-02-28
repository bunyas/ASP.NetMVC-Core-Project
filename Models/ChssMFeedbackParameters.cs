using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssMFeedbackParameters
    {
        public int FacilityCode { get; set; }
        public string SapCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string Facility { get; set; }
        public string DistrictName { get; set; }
        public string LevelDesc { get; set; }
        public string Cdcregion { get; set; }
        public string ComprehensiveImplimentingPartnerDescription { get; set; }
        public string Scto { get; set; }
        public int? UnderStock { get; set; }
        public double? UnderStockPercent { get; set; }
        public int? OverStock { get; set; }
        public double? OverStockPercent { get; set; }
        public int? RightStock { get; set; }
        public double? RightStockPercent { get; set; }
        public int? StockedOut { get; set; }
        public double? StockedOutPercent { get; set; }
        public int? Redistribution { get; set; }
        public double? RedistributionPercent { get; set; }
        public int? Total { get; set; }
    }
}
