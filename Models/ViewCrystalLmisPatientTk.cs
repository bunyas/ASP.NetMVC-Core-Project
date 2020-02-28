using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewCrystalLmisPatientTk
    {
        public int? EndMonth { get; set; }
        public string EndMonthName { get; set; }
        public int? EndYear { get; set; }
        public double? Hct { get; set; }
        public double? Pmtct { get; set; }
        public double? ClinicalDiagnosis { get; set; }
        public double? QualityControl { get; set; }
        public double? NoOfTests { get; set; }
        public int? LocCode { get; set; }
        public string LevelOfCare { get; set; }
        public string OrderNumber { get; set; }
        public string Facility { get; set; }
        public int FacilityCode { get; set; }
    }
}
