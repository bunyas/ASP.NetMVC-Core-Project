using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcBidStatusAction
    {
        public ProcBidStatusAction()
        {
            ProcBidStatusReport = new HashSet<ProcBidStatusReport>();
            ProcBidStatusReportActionTaken = new HashSet<ProcBidStatusReportActionTaken>();
        }

        public int ActionCode { get; set; }
        public string ActionDetail { get; set; }

        public virtual ICollection<ProcBidStatusReport> ProcBidStatusReport { get; set; }
        public virtual ICollection<ProcBidStatusReportActionTaken> ProcBidStatusReportActionTaken { get; set; }
    }
}
