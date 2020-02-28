using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineFocusGroupDiscussionIndicators
    {
        public HssBaselineFocusGroupDiscussionIndicators()
        {
            HssBaselineFocusGroupDiscussionSubIndicator = new HashSet<HssBaselineFocusGroupDiscussionSubIndicator>();
        }

        public int IndicatorCode { get; set; }
        public string IndicatorDesc { get; set; }

        public virtual ICollection<HssBaselineFocusGroupDiscussionSubIndicator> HssBaselineFocusGroupDiscussionSubIndicator { get; set; }
    }
}
