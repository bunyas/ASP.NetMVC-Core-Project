using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisConsumptionArv
    {
        public int? DeliveryZoneCode { get; set; }
        public int? DistrrictCode { get; set; }
        public int FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? AllocationMonth { get; set; }
        public int? AllocationYear { get; set; }
        public int DrugCode { get; set; }
        public double? PmtctConsumption { get; set; }
        public double? ArtConsumption { get; set; }
        public double TotalConsumption { get; set; }
        public double? MonthsStockAtHand { get; set; }
        public double? ClosingBalance { get; set; }
        public double? StockLevel { get; set; }
    }
}
