using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssNeedsAssessment3
    {
        public HssNeedsAssessment3()
        {
            HssNeedsAssessment = new HashSet<HssNeedsAssessment>();
            HssNeedsAssessment4 = new HashSet<HssNeedsAssessment4>();
            HssNeedsAssessmentSpaceOptimization = new HashSet<HssNeedsAssessmentSpaceOptimization>();
        }

        public int HssNeedsAssessment3Code { get; set; }
        public string HssNeedsAssessment3Desc { get; set; }

        public virtual ICollection<HssNeedsAssessment> HssNeedsAssessment { get; set; }
        public virtual ICollection<HssNeedsAssessment4> HssNeedsAssessment4 { get; set; }
        public virtual ICollection<HssNeedsAssessmentSpaceOptimization> HssNeedsAssessmentSpaceOptimization { get; set; }
    }
}
