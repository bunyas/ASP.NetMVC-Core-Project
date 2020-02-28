using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewWebTemplateHivTestKitsSummary
    {
        public int ProductOrder { get; set; }
        public int? ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Hct { get; set; }
        public int Pmtct { get; set; }
        public int ClinicalDiagnosis { get; set; }
        public int Smc { get; set; }
        public int QualityControl { get; set; }
        public int Total { get; set; }
    }
}
