using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewHssBaselineLaboratoryChecklist
    {
        public int LabChecklist1Code { get; set; }
        public string LabChecklist1Desc { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? InterviewDate { get; set; }
        public string YesNo { get; set; }
    }
}
