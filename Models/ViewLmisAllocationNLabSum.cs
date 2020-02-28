using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisAllocationNLabSum
    {
        public int? QuantityAllocated { get; set; }
        public int ItemCode { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartDate { get; set; }
        public int? FacilityCode { get; set; }
    }
}
