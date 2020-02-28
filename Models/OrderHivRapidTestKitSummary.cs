using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class OrderHivRapidTestKitSummary
    {
        public string OrderNumber { get; set; }
        public int ItemCode { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double? Hct { get; set; }
        public double? Pmtct { get; set; }
        public double? ClinicalDiagnosis { get; set; }
        public double? Smc { get; set; }
        public double? QualityControl { get; set; }
        public double? Total { get; set; }

        public virtual AProduct ItemCodeNavigation { get; set; }
        public virtual OrderHivRapidTestKitHeader OrderNumberNavigation { get; set; }
    }
}
