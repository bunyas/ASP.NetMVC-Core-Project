using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewHssBaselineLaboratory
    {
        public int LabAssessmentQnCode { get; set; }
        public int LabIndicatorCode { get; set; }
        public string LabAssessmentQnDesc { get; set; }
        public string LaboratoryMethodDesc { get; set; }
        public string LaboratoryIndicatorDesc { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? InterviewDate { get; set; }
        public string LaboratoryYesNo { get; set; }
        public string LaboratoryRemarks { get; set; }
    }
}
