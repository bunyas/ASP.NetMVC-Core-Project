using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcTracker
    {
        public ProcTracker()
        {
            ProcTrackerAwardPfi = new HashSet<ProcTrackerAwardPfi>();
        }

        public string ReferenceNo { get; set; }
        public string TaskOrderNo { get; set; }
        public int? OrderType { get; set; }
        public int? NormalEmergencyProcurement { get; set; }

        public virtual ProcTrackerTaskNo TaskOrderNoNavigation { get; set; }
        public virtual ICollection<ProcTrackerAwardPfi> ProcTrackerAwardPfi { get; set; }
    }
}
