using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistWorkingDaysMonth
    {
        public int MonthId { get; set; }
        public int Year { get; set; }
        public int? WorkingDays { get; set; }

        public virtual AMonth Month { get; set; }
    }
}
