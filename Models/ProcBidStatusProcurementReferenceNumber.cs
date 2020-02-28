using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcBidStatusProcurementReferenceNumber
    {
        public string ProcurementReferenceNumber { get; set; }
        public int? OrderOrgan { get; set; }
        public int? OrderType { get; set; }
        public int? OrderYear { get; set; }
        public int? OrderQuater { get; set; }
        public int? OrderCategory { get; set; }
        public string OrderNo { get; set; }
        public int? TaskOrderNo { get; set; }

        public virtual ProcBidStatusReport ProcBidStatusReport { get; set; }
    }
}
