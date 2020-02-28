using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssStockManagement
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int ProductCode { get; set; }
        public bool? ItemAvailable { get; set; }
        public int? ExpiredQuantity { get; set; }
        public int? CardAvailability { get; set; }
        public int? MonthlyPhysicalCount { get; set; }
        public int? CorrectCardFill { get; set; }
        public int? StockCardBalance { get; set; }
        public int? StoreQuantity { get; set; }
        public int? StockBookAvailability { get; set; }
        public int? CorrectStockBookUse { get; set; }
        public double? Amc { get; set; }
        public int? QuantityIssued { get; set; }
        public int? OutOfStockDays { get; set; }
        public double? PharmacyQuantity { get; set; }
        public double? CalculatedAmc { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual AProduct ProductCodeNavigation { get; set; }
    }
}
