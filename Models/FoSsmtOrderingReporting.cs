using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoSsmtOrderingReporting
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int ProductCode { get; set; }
        public int? UnitPack { get; set; }
        public double? ClosingStockStockCard { get; set; }
        public double? ClosingStockFacilityReport { get; set; }
        public bool? ClosingStockDataAgrees { get; set; }
        public double? ConsumptionPreviousReportingCycle { get; set; }
        public double? ConsumptionFacilityReport { get; set; }
        public bool? ConsumptionDataAgrees { get; set; }
        public int? PatientNoPerDrugReport { get; set; }
        public int? PatientNoPerDrugActualSite { get; set; }
        public bool? DifferenceInPatientNos { get; set; }

        public virtual FoSsmtFacility FoSsmtFacility { get; set; }
    }
}
