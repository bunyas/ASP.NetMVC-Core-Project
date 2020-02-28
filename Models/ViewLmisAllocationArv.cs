using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisAllocationArv
    {
        public int? DeliveryZoneCode { get; set; }
        public int? DistrrictCode { get; set; }
        public int FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? AllocationMonth { get; set; }
        public int? AllocationYear { get; set; }
        public int DrugCode { get; set; }
        public double? TotalDrugsRequired { get; set; }
        public double? QuantityAllocated { get; set; }
        public double? OrderFulfillment { get; set; }
    }
}
