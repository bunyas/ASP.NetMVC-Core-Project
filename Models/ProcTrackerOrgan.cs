using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcTrackerOrgan
    {
        public ProcTrackerOrgan()
        {
            ProcTrackerPurchaseOrderNo = new HashSet<ProcTrackerPurchaseOrderNo>();
        }

        public int OrganCode { get; set; }
        public string OrganDesc { get; set; }

        public virtual ICollection<ProcTrackerPurchaseOrderNo> ProcTrackerPurchaseOrderNo { get; set; }
    }
}
