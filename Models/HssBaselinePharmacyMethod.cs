using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselinePharmacyMethod
    {
        public HssBaselinePharmacyMethod()
        {
            HssBaselinePharmacyAssessmentQuestion = new HashSet<HssBaselinePharmacyAssessmentQuestion>();
        }

        public int PharmacyMethodCode { get; set; }
        public string PharmacyMethodDesc { get; set; }

        public virtual ICollection<HssBaselinePharmacyAssessmentQuestion> HssBaselinePharmacyAssessmentQuestion { get; set; }
    }
}
