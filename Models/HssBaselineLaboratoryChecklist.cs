using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineLaboratoryChecklist
    {
        public int FacilityCode { get; set; }
        public DateTime InterviewDate { get; set; }
        public int LabChecklist1Code { get; set; }
        public int? YesNo { get; set; }
    }
}
