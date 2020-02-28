using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoComplaintInvestigationQualIssue
    {
        public int Id { get; set; }
        public int ERegComplaintCode { get; set; }
        public string InvestigationCode { get; set; }
        public string BatchNo { get; set; }
        public int ProductCode { get; set; }
        public int? YesNo { get; set; }
        public string RequiredEvidence { get; set; }
        public string FileUrl { get; set; }
        public string FileType { get; set; }
        public string Details { get; set; }
        public string ERegComplaintNo { get; set; }

        public virtual FoAInvestigation InvestigationCodeNavigation { get; set; }
        public virtual AYesNo YesNoNavigation { get; set; }
    }
}
