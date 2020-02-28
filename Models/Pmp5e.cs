using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class Pmp5e
    {
        public string CopYear { get; set; }
        public string Period { get; set; }
        public DateTime? Months { get; set; }
        public int? SitesExpectedToReport { get; set; }
        public int? SitesThatReported { get; set; }
        public int? SitesThatReportedOntime { get; set; }
        public double? ReportingRates { get; set; }
        public double? TimelinessOfReporting { get; set; }
    }
}
