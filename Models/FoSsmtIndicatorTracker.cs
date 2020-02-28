using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoSsmtIndicatorTracker
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int IndicatorCode { get; set; }
        public int IndicatorGuidlineCode { get; set; }
        public bool? YesNo { get; set; }
        public int? MaxScore { get; set; }
        public int? Score { get; set; }

        public virtual FoSsmtFacility FoSsmtFacility { get; set; }
        public virtual FoSsmtIndicator IndicatorCodeNavigation { get; set; }
    }
}
