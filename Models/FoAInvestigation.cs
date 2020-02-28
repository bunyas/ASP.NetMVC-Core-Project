using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoAInvestigation
    {
        public FoAInvestigation()
        {
            FoComplaintInvestigation = new HashSet<FoComplaintInvestigation>();
            FoComplaintInvestigationQualIssue = new HashSet<FoComplaintInvestigationQualIssue>();
        }

        public string InvestigationCode { get; set; }
        public string InvestigationDesc { get; set; }
        public string Code { get; set; }

        public virtual ICollection<FoComplaintInvestigation> FoComplaintInvestigation { get; set; }
        public virtual ICollection<FoComplaintInvestigationQualIssue> FoComplaintInvestigationQualIssue { get; set; }
    }
}
