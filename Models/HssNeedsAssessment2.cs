using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssNeedsAssessment2
    {
        public HssNeedsAssessment2()
        {
            HssNeedsAssessment = new HashSet<HssNeedsAssessment>();
            HssNeedsAssessment4 = new HashSet<HssNeedsAssessment4>();
            HssNeedsAssessmentItInfrastracture = new HashSet<HssNeedsAssessmentItInfrastracture>();
            HssNeedsAssessmentPhysicalInfrastructure = new HashSet<HssNeedsAssessmentPhysicalInfrastructure>();
            HssNeedsAssessmentSpaceOptimization = new HashSet<HssNeedsAssessmentSpaceOptimization>();
        }

        public int HssNeedsAssessment2Code { get; set; }
        public int? HssNeedsAssessment1Code { get; set; }
        public string HssNeedsAssessment2Desc { get; set; }

        public virtual HssNeedsAssessment1 HssNeedsAssessment1CodeNavigation { get; set; }
        public virtual ICollection<HssNeedsAssessment> HssNeedsAssessment { get; set; }
        public virtual ICollection<HssNeedsAssessment4> HssNeedsAssessment4 { get; set; }
        public virtual ICollection<HssNeedsAssessmentItInfrastracture> HssNeedsAssessmentItInfrastracture { get; set; }
        public virtual ICollection<HssNeedsAssessmentPhysicalInfrastructure> HssNeedsAssessmentPhysicalInfrastructure { get; set; }
        public virtual ICollection<HssNeedsAssessmentSpaceOptimization> HssNeedsAssessmentSpaceOptimization { get; set; }
    }
}
