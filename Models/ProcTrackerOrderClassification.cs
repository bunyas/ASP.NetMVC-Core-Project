using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcTrackerOrderClassification
    {
        public ProcTrackerOrderClassification()
        {
            ProcTrackerOrder = new HashSet<ProcTrackerOrder>();
        }

        public int OrderClassificationCode { get; set; }
        public string OrderClassificationDesc { get; set; }

        public virtual ICollection<ProcTrackerOrder> ProcTrackerOrder { get; set; }
    }
}
