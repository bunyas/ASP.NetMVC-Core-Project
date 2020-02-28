using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class TreatmentFluconazole
    {
        public string OrderNumber { get; set; }
        public int ConditionCode { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Adults { get; set; }
        public int? Children { get; set; }

        public virtual ATreatmentFluconazole ConditionCodeNavigation { get; set; }
        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual OrderHeader OrderNumberNavigation { get; set; }
    }
}
