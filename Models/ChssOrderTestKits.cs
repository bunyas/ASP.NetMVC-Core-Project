using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssOrderTestKits
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int ProductCode { get; set; }
        public int? Availability { get; set; }
        public int? OrderQuantity { get; set; }
        public int? RegisterQuantity { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual AProduct ProductCodeNavigation { get; set; }
    }
}
