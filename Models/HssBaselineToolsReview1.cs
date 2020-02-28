using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineToolsReview1
    {
        public HssBaselineToolsReview1()
        {
            HssBaselineToolsReview2 = new HashSet<HssBaselineToolsReview2>();
        }

        public int ToolsReview1Code { get; set; }
        public string ToolsReview1Desc { get; set; }

        public virtual ICollection<HssBaselineToolsReview2> HssBaselineToolsReview2 { get; set; }
    }
}
