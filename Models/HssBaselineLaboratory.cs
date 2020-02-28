using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineLaboratory
    {
        public int FacilityCode { get; set; }
        public DateTime InterviewDate { get; set; }
        public int LaboratoryAssessmentQnCode { get; set; }
        public int? LaboratoryYesNo { get; set; }
        public string LaboratoryRemarks { get; set; }

        public virtual HssBaselineMaster HssBaselineMaster { get; set; }
        public virtual HssBaselineLaboratoryAssessmentQuestion LaboratoryAssessmentQnCodeNavigation { get; set; }
    }
}
