using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class PmpPerformanceIndicatorCopYear
    {
        public int CopYear { get; set; }
        public string PmpIndicatorCode { get; set; }
        public string NumeratorDenominatorCode { get; set; }
        public double? Q1 { get; set; }
        public double? Q2 { get; set; }
        public double? Q3 { get; set; }
        public double? Q4 { get; set; }

        public virtual PmpPerformanceIndicatorNumeratorDenominator NumeratorDenominatorCodeNavigation { get; set; }
    }
}
