using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineLaboratoryIndicator
    {
        public HssBaselineLaboratoryIndicator()
        {
            HssBaselineLaboratoryAssessmentQuestion = new HashSet<HssBaselineLaboratoryAssessmentQuestion>();
        }

        public int LaboratoryIndicatorCode { get; set; }
        public string LaboratoryIndicatorDesc { get; set; }

        public virtual ICollection<HssBaselineLaboratoryAssessmentQuestion> HssBaselineLaboratoryAssessmentQuestion { get; set; }
    }
}
