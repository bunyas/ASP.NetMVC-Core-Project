using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselinePharmacyIndicator
    {
        public HssBaselinePharmacyIndicator()
        {
            HssBaselinePharmacyAssessmentQuestion = new HashSet<HssBaselinePharmacyAssessmentQuestion>();
        }

        public int PharmacyIndicatorCode { get; set; }
        public string PharmacyIndicatorDesc { get; set; }

        public virtual ICollection<HssBaselinePharmacyAssessmentQuestion> HssBaselinePharmacyAssessmentQuestion { get; set; }
    }
}
