using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class PmpPerformanceIndicatorNumeratorDenominator
    {
        public PmpPerformanceIndicatorNumeratorDenominator()
        {
            PmpPerformanceIndicatorCopYear = new HashSet<PmpPerformanceIndicatorCopYear>();
        }

        public string NumeratorDenominatorCode { get; set; }
        public string PmpIndicatorCode { get; set; }
        public string NumeratorDenominatorDesc { get; set; }

        public virtual ICollection<PmpPerformanceIndicatorCopYear> PmpPerformanceIndicatorCopYear { get; set; }
    }
}
