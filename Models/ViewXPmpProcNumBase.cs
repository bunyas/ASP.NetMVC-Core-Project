using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewXPmpProcNumBase
    {
        public int? ProductCode { get; set; }
        public DateTime? DateIssueAward { get; set; }
        public int? OrderYear { get; set; }
        public int? OrderQuater { get; set; }
        public int? OrderCategory { get; set; }
        public int? NormalOrEmergencyProcurement { get; set; }
        public int? ProductTypeCode { get; set; }
        public bool? NtgApproved { get; set; }
        public bool? WhoApproved { get; set; }
        public bool? ConsistentNationalProcurementPlan { get; set; }
        public double? ProcurementQuantity { get; set; }
        public double? AwardFobPrice { get; set; }
        public double? AwardScmsPrice { get; set; }
    }
}
