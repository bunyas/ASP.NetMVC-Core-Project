using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssNeedsAssessmentPhysicalInfrastructure
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int HssNeedsAssessment2Code { get; set; }
        public string Room1 { get; set; }
        public string Room2 { get; set; }
        public string Room3 { get; set; }
        public string Room4 { get; set; }
        public string Comment { get; set; }

        public virtual HssNeedsAssessment2 HssNeedsAssessment2CodeNavigation { get; set; }
        public virtual HssNeedsAssessmentMaster HssNeedsAssessmentMaster { get; set; }
        public virtual HssNeedsAssessment5 Room1Navigation { get; set; }
        public virtual HssNeedsAssessment5 Room2Navigation { get; set; }
        public virtual HssNeedsAssessment5 Room3Navigation { get; set; }
        public virtual HssNeedsAssessment5 Room4Navigation { get; set; }
    }
}
