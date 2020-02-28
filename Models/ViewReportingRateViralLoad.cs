using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewReportingRateViralLoad
    {
        public int FacilityCode { get; set; }
        public int? FcExpected { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ProductCategory { get; set; }
        public int? FacilityCode1 { get; set; }
        public int? FcReported { get; set; }
        public DateTime? StartDate1 { get; set; }
        public DateTime? EndDate1 { get; set; }
    }
}
