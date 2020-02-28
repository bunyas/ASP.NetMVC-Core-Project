using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewAllocationSmc
    {
        public int FacilityCode { get; set; }
        public int? BMonth { get; set; }
        public int? BYear { get; set; }
        public int ItemCode { get; set; }
        public int? QuantityAllocated { get; set; }
    }
}
