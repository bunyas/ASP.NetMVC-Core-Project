using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcTrackerPurchaseOrderNo
    {
        public string PurchaseOrderNo { get; set; }
        public int? OrderOrgan { get; set; }
        public int? OrderType { get; set; }
        public int? OrderYear { get; set; }
        public int? OrderQuater { get; set; }
        public int? OrderCategory { get; set; }
        public string OrderNo { get; set; }
        public int? Addendum { get; set; }
        public int? TaskOrderNo { get; set; }

        public virtual ProcTrackerCategory OrderCategoryNavigation { get; set; }
        public virtual ProcTrackerOrgan OrderOrganNavigation { get; set; }
        public virtual ProcTrackerQuarter OrderQuaterNavigation { get; set; }
        public virtual ProcTrackerOrderType OrderTypeNavigation { get; set; }
    }
}
