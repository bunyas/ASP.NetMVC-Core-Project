using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewPmpMetrix
    {
        public string CopYear { get; set; }
        public string PmpIndicatorCode { get; set; }
        public string PmpIndicatorDesc { get; set; }
        public int? PmpDataCollectionFrequencyCode { get; set; }
        public string Rationale { get; set; }
        public string PmpTarget { get; set; }
        public string Q1 { get; set; }
        public string Q2 { get; set; }
        public string Q3 { get; set; }
        public string Q4 { get; set; }
        public string PmpObjectiveDesc { get; set; }
        public string PmpDataCollectionFrequencyDesc { get; set; }
    }
}
