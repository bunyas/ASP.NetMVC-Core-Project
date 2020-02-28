using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoSsmtStockManagementScore
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int IndicatorCode { get; set; }
        public int? Weight { get; set; }
        public int? Score { get; set; }
        public double? WeightedScore { get; set; }
        public double? PercentageWeightedScore { get; set; }

        public virtual FoSsmtFacility FoSsmtFacility { get; set; }
    }
}
