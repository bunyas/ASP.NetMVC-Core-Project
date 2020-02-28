using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineToolsReview
    {
        public int FacilityCode { get; set; }
        public DateTime InterviewDate { get; set; }
        public int ToolsReview2Code { get; set; }
        public int? Avialable { get; set; }
        public int? Displayed { get; set; }

        public virtual HssBaselineMaster HssBaselineMaster { get; set; }
        public virtual HssBaselineToolsReview2 ToolsReview2CodeNavigation { get; set; }
    }
}
