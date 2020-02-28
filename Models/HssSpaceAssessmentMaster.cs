using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssSpaceAssessmentMaster
    {
        public HssSpaceAssessmentMaster()
        {
            HssSpaceAssessment = new HashSet<HssSpaceAssessment>();
            HssSpaceAssessmentInterviewee = new HashSet<HssSpaceAssessmentInterviewee>();
            HssSpaceAssessmentInterviewer = new HashSet<HssSpaceAssessmentInterviewer>();
            HssSpaceAssessmentKeyInformantInterview = new HashSet<HssSpaceAssessmentKeyInformantInterview>();
        }

        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public bool? RecordStatus { get; set; }

        public virtual ICollection<HssSpaceAssessment> HssSpaceAssessment { get; set; }
        public virtual ICollection<HssSpaceAssessmentInterviewee> HssSpaceAssessmentInterviewee { get; set; }
        public virtual ICollection<HssSpaceAssessmentInterviewer> HssSpaceAssessmentInterviewer { get; set; }
        public virtual ICollection<HssSpaceAssessmentKeyInformantInterview> HssSpaceAssessmentKeyInformantInterview { get; set; }
    }
}
