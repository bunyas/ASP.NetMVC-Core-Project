using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDashboardConsumptionHiv
    {
        public int ItemCode { get; set; }
        public string Facility { get; set; }
        public string ProductDescription { get; set; }
        public string EndMonthName { get; set; }
        public int? EndMonth { get; set; }
        public int? EndYear { get; set; }
        public int FacilityCode { get; set; }
        public double? Hct { get; set; }
        public double? Pmtct { get; set; }
        public double? ClinicalDiagnosis { get; set; }
        public double? QualityControl { get; set; }
        public double? NoOfTests { get; set; }
    }
}
