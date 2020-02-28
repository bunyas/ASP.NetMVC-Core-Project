using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class PmpPerformanceIndicator
    {
        public string PmpIndicatorCode { get; set; }
        public int PmpObjectiveCode { get; set; }
        public string PmpIndicatorDesc { get; set; }
        public int? PmpDataCollectionFrequencyCode { get; set; }
        public string Rationale { get; set; }
        public string PmpTarget { get; set; }

        public virtual PmpDataCollectionFrequency PmpDataCollectionFrequencyCodeNavigation { get; set; }
        public virtual PmpObjective PmpObjectiveCodeNavigation { get; set; }
    }
}
