using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcTrackerCategory
    {
        public ProcTrackerCategory()
        {
            ProcTrackerPurchaseOrderNo = new HashSet<ProcTrackerPurchaseOrderNo>();
        }

        public int CategoryCode { get; set; }
        public int? OrderTypeId { get; set; }
        public string CategoryDesc { get; set; }

        public virtual ProcTrackerOrderType OrderType { get; set; }
        public virtual ICollection<ProcTrackerPurchaseOrderNo> ProcTrackerPurchaseOrderNo { get; set; }
    }
}
