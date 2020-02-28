using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AMonth
    {
        public AMonth()
        {
            DistWorkingDaysMonth = new HashSet<DistWorkingDaysMonth>();
        }

        public int MonthId { get; set; }
        public string MonthDesc { get; set; }

        public virtual ICollection<DistWorkingDaysMonth> DistWorkingDaysMonth { get; set; }
    }
}
