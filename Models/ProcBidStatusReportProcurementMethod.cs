using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcBidStatusReportProcurementMethod
    {
        public ProcBidStatusReportProcurementMethod()
        {
            ProcBidStatusReport = new HashSet<ProcBidStatusReport>();
        }

        public int ProcMethodCode { get; set; }
        public string ProcMethodDesc { get; set; }

        public virtual ICollection<ProcBidStatusReport> ProcBidStatusReport { get; set; }
    }
}
