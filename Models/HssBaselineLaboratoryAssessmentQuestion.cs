using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineLaboratoryAssessmentQuestion
    {
        public HssBaselineLaboratoryAssessmentQuestion()
        {
            HssBaselineLaboratory = new HashSet<HssBaselineLaboratory>();
        }

        public int LabAssessmentQnCode { get; set; }
        public int LabIndicatorCode { get; set; }
        public string LabAssessmentQnDesc { get; set; }
        public int? LabMethodCode { get; set; }

        public virtual HssBaselineLaboratoryIndicator LabIndicatorCodeNavigation { get; set; }
        public virtual HssBaselineLaboratoryMethod LabMethodCodeNavigation { get; set; }
        public virtual ICollection<HssBaselineLaboratory> HssBaselineLaboratory { get; set; }
    }
}
