using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssMStockManagement
    {
        public int FacilityCode { get; set; }
        public string SapCode { get; set; }
        public int? DistrrictCode { get; set; }
        public string DistrictName { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public string ImplimentingPartnerDescription { get; set; }
        public string Facility { get; set; }
        public int? LevelOfCare { get; set; }
        public string LevelDesc { get; set; }
        public int? CdcregionId { get; set; }
        public string Cdcregion { get; set; }
        public int? ComprehensiveImplimentingPartnerCode { get; set; }
        public string ComprehensiveImplimentingPartnerDescription { get; set; }
        public string Scto { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Packsize { get; set; }
        public int ItemAvailable { get; set; }
        public int? ExpiredQuantity { get; set; }
        public string CardAvailability { get; set; }
        public string MonthlyPhysicalCount { get; set; }
        public string CorrectCardFil { get; set; }
        public string StockCardBalance { get; set; }
        public int? StoreQuantity { get; set; }
        public string BalanceComparison { get; set; }
        public string StockBookAvailability { get; set; }
        public string CorrectStockBookUse { get; set; }
        public string Amc { get; set; }
        public int? QuantityIssued { get; set; }
        public int? OutOfStockDays { get; set; }
        public double? PharmacyQuantity { get; set; }
        public double? CalculatedAmc { get; set; }
        public int AmcComparison { get; set; }
        public double? FacilityQuantity { get; set; }
        public double? MonthOfStock { get; set; }
        public string StockStatus { get; set; }
        public string Recommendation { get; set; }
        public double? QuantityToLend { get; set; }
        public double? QuantityToBorrow { get; set; }
        public int? ProductCount { get; set; }
        public int? FacilityCount { get; set; }
    }
}
