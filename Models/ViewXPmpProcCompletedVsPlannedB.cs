using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewXPmpProcCompletedVsPlannedB
    {
        public double? AwardQuantityOrdered { get; set; }
        public int? OrderYear { get; set; }
        public int? OrderQuater { get; set; }
        public string ReferenceNo { get; set; }
        public DateTime? AwardExpectedDateDelivery { get; set; }
        public DateTime? DateOfArrivalAtPort { get; set; }
    }
}
