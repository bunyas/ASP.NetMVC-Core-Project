using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SsmtVerificationLmisData
    {
        public int FacilityId { get; set; }
        public DateTime DateVisit { get; set; }
        public int ProductCode { get; set; }
        public int? ItemAvialable { get; set; }
        public double? ClosingStockStockCard { get; set; }
        public double? ClosingStockFacilityReport { get; set; }
        public int? ClosingStockDataAgrees { get; set; }
        public double? ConsumptionSiteRecords { get; set; }
        public double? ConsumptionFacilityReport { get; set; }
        public int? ConsumptionDataAgrees { get; set; }
        public int? MaxScore { get; set; }
        public int? Score { get; set; }

        public virtual AProduct ProductCodeNavigation { get; set; }
        public virtual SsmtFacility SsmtFacility { get; set; }
    }
}
