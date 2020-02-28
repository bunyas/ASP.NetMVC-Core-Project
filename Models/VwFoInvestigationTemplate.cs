using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class VwFoInvestigationTemplate
    {
        public string InvestigationCode { get; set; }
        public string InvestigationDesc { get; set; }
        public string Code { get; set; }
        public int? ERegComplaintCode { get; set; }
        public int? YesNo { get; set; }
        public string RequiredEvidence { get; set; }
        public string FileUrl { get; set; }
        public string FileType { get; set; }
        public string Details { get; set; }
    }
}
