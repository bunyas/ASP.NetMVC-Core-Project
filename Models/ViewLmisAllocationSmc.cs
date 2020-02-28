using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisAllocationSmc
    {
        public int? DeliveryZoneCode { get; set; }
        public int? DistrrictCode { get; set; }
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public int? AllocationMonth { get; set; }
        public int? AllocationYear { get; set; }
        public int ItemCode { get; set; }
        public DateTime EndDate { get; set; }
        public double? QuantityToOrder { get; set; }
        public int? QuantityAllocated { get; set; }
        public double? OrderFulfillment { get; set; }
    }
}
