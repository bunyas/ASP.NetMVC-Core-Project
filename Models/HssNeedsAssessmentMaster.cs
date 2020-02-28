using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssNeedsAssessmentMaster
    {
        public HssNeedsAssessmentMaster()
        {
            HssNeedsAssessmentInterviewee = new HashSet<HssNeedsAssessmentInterviewee>();
            HssNeedsAssessmentInterviewer = new HashSet<HssNeedsAssessmentInterviewer>();
            HssNeedsAssessmentItInfrastracture = new HashSet<HssNeedsAssessmentItInfrastracture>();
            HssNeedsAssessmentPhysicalInfrastructure = new HashSet<HssNeedsAssessmentPhysicalInfrastructure>();
            HssNeedsAssessmentSpaceOptimization = new HashSet<HssNeedsAssessmentSpaceOptimization>();
        }

        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public bool? RecordStatus { get; set; }

        public virtual ICollection<HssNeedsAssessmentInterviewee> HssNeedsAssessmentInterviewee { get; set; }
        public virtual ICollection<HssNeedsAssessmentInterviewer> HssNeedsAssessmentInterviewer { get; set; }
        public virtual ICollection<HssNeedsAssessmentItInfrastracture> HssNeedsAssessmentItInfrastracture { get; set; }
        public virtual ICollection<HssNeedsAssessmentPhysicalInfrastructure> HssNeedsAssessmentPhysicalInfrastructure { get; set; }
        public virtual ICollection<HssNeedsAssessmentSpaceOptimization> HssNeedsAssessmentSpaceOptimization { get; set; }
    }
}
