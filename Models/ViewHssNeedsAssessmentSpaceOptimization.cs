using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewHssNeedsAssessmentSpaceOptimization
    {
        public int HssNeedsAssessment1Code { get; set; }
        public int HssNeedsAssessment2Code { get; set; }
        public int HssNeedsAssessment3Code { get; set; }
        public string HssNeedsAssessment1Desc { get; set; }
        public string HssNeedsAssessment2Desc { get; set; }
        public string HssNeedsAssessment3Desc { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? DateOfVisit { get; set; }
        public string ArvProposedStorage { get; set; }
        public string GeneralMedicine { get; set; }
        public string ArvCurrentStorage { get; set; }
        public string Room4 { get; set; }
        public string Comment { get; set; }
    }
}
