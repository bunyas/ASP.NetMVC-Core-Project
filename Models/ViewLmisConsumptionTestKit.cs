using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisConsumptionTestKit
    {
        public int? DeliveryZoneCode { get; set; }
        public int? DistrrictCode { get; set; }
        public int FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int ItemCode { get; set; }
        public int? AllocationMonth { get; set; }
        public int? AllocationYear { get; set; }
        public double? Consumption { get; set; }
        public double? ClosingBalance { get; set; }
        public double? StockLevel { get; set; }
    }
}
