using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineHfService
    {
        public int FacilityCode { get; set; }
        public DateTime InterviewDate { get; set; }
        public int HfService2Code { get; set; }
        public int? HfServiceValue { get; set; }
        public DateTime? HfServiceDateTime { get; set; }
        public string HfServiceRemarks { get; set; }

        public virtual HssBaselineHfService2 HfService2CodeNavigation { get; set; }
        public virtual HssBaselineMaster HssBaselineMaster { get; set; }
    }
}
