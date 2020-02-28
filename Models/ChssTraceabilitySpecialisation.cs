using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssTraceabilitySpecialisation
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int ClassificationCode { get; set; }
        public bool? Result { get; set; }

        public virtual ChssTraceabilitySpecializationClassification ClassificationCodeNavigation { get; set; }
        public virtual AFacilities FacilityCodeNavigation { get; set; }
    }
}
