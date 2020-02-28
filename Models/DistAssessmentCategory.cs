using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistAssessmentCategory
    {
        public DistAssessmentCategory()
        {
            DistAssessment = new HashSet<DistAssessment>();
        }

        public int AssessmentCategoryCode { get; set; }
        public string AssessmentCategoryDesc { get; set; }

        public virtual ICollection<DistAssessment> DistAssessment { get; set; }
    }
}
