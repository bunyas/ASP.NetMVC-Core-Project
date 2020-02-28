using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class LmisSummaryIndicator
    {
        public LmisSummaryIndicator()
        {
            LmisSummarySubIndicator = new HashSet<LmisSummarySubIndicator>();
        }

        public int IndicatorCode { get; set; }
        public int? CategoryCode { get; set; }
        public string IndicatorDesc { get; set; }

        public virtual LmisSummaryCategory CategoryCodeNavigation { get; set; }
        public virtual ICollection<LmisSummarySubIndicator> LmisSummarySubIndicator { get; set; }
    }
}
