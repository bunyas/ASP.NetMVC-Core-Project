using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssSpaceAssessment2
    {
        public HssSpaceAssessment2()
        {
            HssSpaceAssessment = new HashSet<HssSpaceAssessment>();
            HssSpaceAssessment4 = new HashSet<HssSpaceAssessment4>();
            HssSpaceAssessmentKeyInformantInterview = new HashSet<HssSpaceAssessmentKeyInformantInterview>();
        }

        public int SpaceAssessment2Code { get; set; }
        public int SpaceAssessment1Code { get; set; }
        public string SpaceAssessment2Desc { get; set; }

        public virtual HssSpaceAssessment1 SpaceAssessment1CodeNavigation { get; set; }
        public virtual ICollection<HssSpaceAssessment> HssSpaceAssessment { get; set; }
        public virtual ICollection<HssSpaceAssessment4> HssSpaceAssessment4 { get; set; }
        public virtual ICollection<HssSpaceAssessmentKeyInformantInterview> HssSpaceAssessmentKeyInformantInterview { get; set; }
    }
}
