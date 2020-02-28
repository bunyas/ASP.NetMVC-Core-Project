using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisSummaryHivTests
    {
        public int FacilityCode { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int ItemCode { get; set; }
        public double? Hct { get; set; }
        public double? Pmtct { get; set; }
        public double? ClinicalDiagnosis { get; set; }
        public double? QualityControl { get; set; }
    }
}
