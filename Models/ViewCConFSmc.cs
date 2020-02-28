using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewCConFSmc
    {
        public string XmYearMonth { get; set; }
        public string Product { get; set; }
        public string PackSize { get; set; }
        public string ProductCode { get; set; }
        public double? Consumption { get; set; }
        public string XYear { get; set; }
        public int? XMonth { get; set; }
        public int? XYearMonth { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public string LevelOfCare { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public int? LevelOfCareCode { get; set; }
        public string Facility { get; set; }
        public int FacilityCode { get; set; }
        public string MonthDesc { get; set; }
        public DateTime EndDate { get; set; }
        public string SapCode { get; set; }
    }
}
