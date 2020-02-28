using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssNeedsAssessmentItInfrastracture
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int HssNeedsAssessment2Code { get; set; }
        public string Dispensary { get; set; }
        public string Stores { get; set; }
        public string Comment { get; set; }

        public virtual HssNeedsAssessment5 DispensaryNavigation { get; set; }
        public virtual HssNeedsAssessment2 HssNeedsAssessment2CodeNavigation { get; set; }
        public virtual HssNeedsAssessmentMaster HssNeedsAssessmentMaster { get; set; }
        public virtual HssNeedsAssessment5 StoresNavigation { get; set; }
    }
}
