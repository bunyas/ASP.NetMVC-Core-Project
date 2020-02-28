using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistAssessmentResult
    {
        public DateTime DateOfAssessment { get; set; }
        public string DriverPermitNo { get; set; }
        public int AssessmentCode { get; set; }
        public bool? AssessmentResult { get; set; }
        public string AssessorObservations { get; set; }

        public virtual DistAssessment AssessmentCodeNavigation { get; set; }
        public virtual DistAssessmentResultHeader D { get; set; }
        public virtual DistOperatorPersonal DriverPermitNoNavigation { get; set; }
    }
}
