using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcTrackerOrderType
    {
        public ProcTrackerOrderType()
        {
            ProcTrackerCategory = new HashSet<ProcTrackerCategory>();
            ProcTrackerPurchaseOrderNo = new HashSet<ProcTrackerPurchaseOrderNo>();
        }

        public int OrderTypeId { get; set; }
        public string OrderTypeDesc { get; set; }

        public virtual ICollection<ProcTrackerCategory> ProcTrackerCategory { get; set; }
        public virtual ICollection<ProcTrackerPurchaseOrderNo> ProcTrackerPurchaseOrderNo { get; set; }
    }
}
