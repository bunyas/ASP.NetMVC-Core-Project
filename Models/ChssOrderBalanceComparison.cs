using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssOrderBalanceComparison
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int ProductCode { get; set; }
        public int? Availability { get; set; }
        public int? ClosingBalance { get; set; }
        public int? OpeningBalance { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual AProduct ProductCodeNavigation { get; set; }
    }
}
