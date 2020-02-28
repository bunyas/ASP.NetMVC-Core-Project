using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcProductType
    {
        public ProcProductType()
        {
            ProcTaskDetail = new HashSet<ProcTaskDetail>();
            ProcTrackerAwardPfi = new HashSet<ProcTrackerAwardPfi>();
        }

        public int ProductTypeCode { get; set; }
        public string ProductTypeDesc { get; set; }

        public virtual ICollection<ProcTaskDetail> ProcTaskDetail { get; set; }
        public virtual ICollection<ProcTrackerAwardPfi> ProcTrackerAwardPfi { get; set; }
    }
}
