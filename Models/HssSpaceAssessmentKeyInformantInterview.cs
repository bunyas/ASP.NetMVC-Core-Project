using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssSpaceAssessmentKeyInformantInterview
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int HssSpaceAssessment2Code { get; set; }
        public string HssSpaceAssessmentKiiValue { get; set; }
        public string HssSpaceAssessmentKiiRemark { get; set; }

        public virtual HssSpaceAssessment2 HssSpaceAssessment2CodeNavigation { get; set; }
        public virtual HssSpaceAssessment5 HssSpaceAssessmentKiiValueNavigation { get; set; }
        public virtual HssSpaceAssessmentMaster HssSpaceAssessmentMaster { get; set; }
    }
}
