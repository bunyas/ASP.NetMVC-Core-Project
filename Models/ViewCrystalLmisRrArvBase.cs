using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewCrystalLmisRrArvBase
    {
        public int? NoOfFacilities { get; set; }
        public string Sector { get; set; }
        public double? ReportingRate { get; set; }
        public int? ReportingYear { get; set; }
        public int? ReportingMonth { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
    }
}
