using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineToolsReview2
    {
        public HssBaselineToolsReview2()
        {
            HssBaselineToolsReview = new HashSet<HssBaselineToolsReview>();
        }

        public int ToolsReview2Code { get; set; }
        public int? ToolsReview1Code { get; set; }
        public string ToolsReview2Desc { get; set; }

        public virtual HssBaselineToolsReview1 ToolsReview1CodeNavigation { get; set; }
        public virtual ICollection<HssBaselineToolsReview> HssBaselineToolsReview { get; set; }
    }
}
