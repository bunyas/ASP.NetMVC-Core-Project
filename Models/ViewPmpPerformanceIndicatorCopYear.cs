using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewPmpPerformanceIndicatorCopYear
    {
        public int PmpObjectiveCode { get; set; }
        public string PmpIndicatorCode { get; set; }
        public int? PmpDataCollectionFrequencyCode { get; set; }
        public string Rationale { get; set; }
        public string PmpTarget { get; set; }
        public int? CopYear { get; set; }
        public string PmpIndicatorDesc { get; set; }
        public string NumeratorDenominatorCode { get; set; }
        public string NumeratorDenominatorDesc { get; set; }
        public double? Q1 { get; set; }
        public double? Q2 { get; set; }
        public double? Q3 { get; set; }
        public double? Q4 { get; set; }
    }
}
