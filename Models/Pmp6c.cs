using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class Pmp6c
    {
        public string CopYear { get; set; }
        public string Period { get; set; }
        public DateTime Months { get; set; }
        public string Category { get; set; }
        public int? SitesExpectedToReport { get; set; }
        public int? SitesThatReported { get; set; }
        public int? SitesThatReportedOnTime { get; set; }
        public int? ReportingRates { get; set; }
        public int? TimelinessOfReporting { get; set; }
    }
}
