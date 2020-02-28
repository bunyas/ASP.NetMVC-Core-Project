using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcTaskHeader
    {
        public ProcTaskHeader()
        {
            ProcTask = new HashSet<ProcTask>();
        }

        public string TaskNo { get; set; }
        public DateTime? StartOfPeriod { get; set; }
        public DateTime? EndOfPeriod { get; set; }

        public virtual ICollection<ProcTask> ProcTask { get; set; }
    }
}
