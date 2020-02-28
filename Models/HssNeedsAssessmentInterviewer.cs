using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssNeedsAssessmentInterviewer
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string InterviewerName { get; set; }
        public int? InterviewerPosition { get; set; }
        public string InterviewerPhone { get; set; }
        public string InterviewerEmail { get; set; }
        public bool? RecordStatus { get; set; }

        public virtual HssNeedsAssessmentMaster HssNeedsAssessmentMaster { get; set; }
    }
}
