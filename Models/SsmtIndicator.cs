using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SsmtIndicator
    {
        public int SubindicatorId { get; set; }
        public int IndicatorId { get; set; }
        public int FacilityId { get; set; }
        public DateTime DateVisited { get; set; }
        public int? MoHHmis { get; set; }
        public int? YesNo { get; set; }
        public int? MaxScore { get; set; }
        public int? Score { get; set; }
        public bool? Exist { get; set; }
        public int? StaffTrained { get; set; }

        public virtual SsmtAIndicator Indicator { get; set; }
        public virtual SsmtFacility SsmtFacility { get; set; }
        public virtual SsmtASubindicator Subindicator { get; set; }
        public virtual AYesNo YesNoNavigation { get; set; }
    }
}
