using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AYesNo
    {
        public AYesNo()
        {
            FoCertificateReleaseFrmQuarantine = new HashSet<FoCertificateReleaseFrmQuarantine>();
            FoClientFeedbackAnyAreasOfConcernNavigation = new HashSet<FoClientFeedback>();
            FoClientFeedbackMaulServices1 = new HashSet<FoClientFeedback>();
            FoClientFeedbackSctoVisitedNavigation = new HashSet<FoClientFeedback>();
            FoComplaint = new HashSet<FoComplaint>();
            FoComplaintInvestigation = new HashSet<FoComplaintInvestigation>();
            FoComplaintInvestigationQualIssue = new HashSet<FoComplaintInvestigationQualIssue>();
            SsmtIndicator = new HashSet<SsmtIndicator>();
        }

        public int YesNoId { get; set; }
        public string YesNoDesc { get; set; }

        public virtual ICollection<FoCertificateReleaseFrmQuarantine> FoCertificateReleaseFrmQuarantine { get; set; }
        public virtual ICollection<FoClientFeedback> FoClientFeedbackAnyAreasOfConcernNavigation { get; set; }
        public virtual ICollection<FoClientFeedback> FoClientFeedbackMaulServices1 { get; set; }
        public virtual ICollection<FoClientFeedback> FoClientFeedbackSctoVisitedNavigation { get; set; }
        public virtual ICollection<FoComplaint> FoComplaint { get; set; }
        public virtual ICollection<FoComplaintInvestigation> FoComplaintInvestigation { get; set; }
        public virtual ICollection<FoComplaintInvestigationQualIssue> FoComplaintInvestigationQualIssue { get; set; }
        public virtual ICollection<SsmtIndicator> SsmtIndicator { get; set; }
    }
}
