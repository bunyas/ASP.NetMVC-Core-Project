using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoSsmtOrderingReportingIndicator
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int IndicatorCode { get; set; }
        public int IndicatorGuidlineCode { get; set; }
        public bool? Exist { get; set; }
        public bool? MohHmisTool { get; set; }
        public int? MaxScore { get; set; }
        public int? Score { get; set; }
    }
}
