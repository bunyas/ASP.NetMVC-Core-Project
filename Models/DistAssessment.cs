using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistAssessment
    {
        public DistAssessment()
        {
            DistAssessmentResult = new HashSet<DistAssessmentResult>();
        }

        public int AssessmentCode { get; set; }
        public int AssessmentCategoryCode { get; set; }
        public string AssessmentDesc { get; set; }

        public virtual DistAssessmentCategory AssessmentCategoryCodeNavigation { get; set; }
        public virtual ICollection<DistAssessmentResult> DistAssessmentResult { get; set; }
    }
}
