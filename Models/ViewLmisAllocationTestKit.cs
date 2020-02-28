using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisAllocationTestKit
    {
        public int? DeliveryZoneCode { get; set; }
        public int? DistrrictCode { get; set; }
        public int FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int ItemCode { get; set; }
        public int? AllocationMonth { get; set; }
        public int? AllocationYear { get; set; }
        public double? QuantityRequired { get; set; }
        public int? QuantityAllocated { get; set; }
        public double? OrderFulfillment { get; set; }
    }
}
