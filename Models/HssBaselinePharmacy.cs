using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselinePharmacy
    {
        public int FacilityCode { get; set; }
        public DateTime InterviewDate { get; set; }
        public int AssessmentQnCode { get; set; }
        public int? YesNo { get; set; }
        public string Remarks { get; set; }

        public virtual HssBaselinePharmacyAssessmentQuestion AssessmentQnCodeNavigation { get; set; }
        public virtual HssBaselineMaster HssBaselineMaster { get; set; }
    }
}
