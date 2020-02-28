using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewHssSpaceAssessmentKeyInformantInterview
    {
        public int SpaceAssessment1Code { get; set; }
        public string SpaceAssessment1Desc { get; set; }
        public int SpaceAssessment2Code { get; set; }
        public string SpaceAssessment2Desc { get; set; }
        public string KiiValue { get; set; }
        public string KiiRemark { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? DateOfVisit { get; set; }
    }
}
