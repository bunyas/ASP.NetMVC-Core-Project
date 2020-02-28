using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcTrackerTaskNo
    {
        public ProcTrackerTaskNo()
        {
            ProcTracker = new HashSet<ProcTracker>();
        }

        public string TaskOrderNo { get; set; }
        public int? TaskOrderCode { get; set; }

        public virtual ICollection<ProcTracker> ProcTracker { get; set; }
    }
}
