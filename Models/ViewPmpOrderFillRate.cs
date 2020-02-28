using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewPmpOrderFillRate
    {
        public DateTime? EndDate { get; set; }
        public double? QuantityAllocated { get; set; }
        public double? TotalDrugsRequired { get; set; }
        public double? OrderFillRate { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
