using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewHssBaselinePharmacy
    {
        public int AssessmentQnCode { get; set; }
        public int PharmacyIndicatorCode { get; set; }
        public string AssessmentQnDesc { get; set; }
        public string PharmacyMethodDesc { get; set; }
        public string PharmacyIndicatorDesc { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? InterviewDate { get; set; }
        public string YesNo { get; set; }
        public string Remarks { get; set; }
    }
}
