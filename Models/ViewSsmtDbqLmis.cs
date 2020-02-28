using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewSsmtDbqLmis
    {
        public int DistrictCode { get; set; }
        public int FacilityCode { get; set; }
        public string DistrictName { get; set; }
        public string Facility { get; set; }
        public string LevelOfCare { get; set; }
        public DateTime DateVisit { get; set; }
        public int ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Strength { get; set; }
        public string Packsize { get; set; }
        public int? ItemAvialable { get; set; }
        public double? ClosingStockStockCard { get; set; }
        public double? ClosingStockFacilityReport { get; set; }
        public int? ClosingStockDataAgrees { get; set; }
        public double? ConsumptionSiteRecords { get; set; }
        public double? ConsumptionFacilityReport { get; set; }
        public int? ConsumptionDataAgrees { get; set; }
        public int? MaxScore { get; set; }
        public int? Score { get; set; }
    }
}
