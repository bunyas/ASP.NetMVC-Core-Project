using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselinePharmacyAssessmentQuestion
    {
        public HssBaselinePharmacyAssessmentQuestion()
        {
            HssBaselinePharmacy = new HashSet<HssBaselinePharmacy>();
        }

        public int AssessmentQnCode { get; set; }
        public int PharmacyIndicatorCode { get; set; }
        public string AssessmentQnDesc { get; set; }
        public int? MethodCode { get; set; }

        public virtual HssBaselinePharmacyMethod MethodCodeNavigation { get; set; }
        public virtual HssBaselinePharmacyIndicator PharmacyIndicatorCodeNavigation { get; set; }
        public virtual ICollection<HssBaselinePharmacy> HssBaselinePharmacy { get; set; }
    }
}
