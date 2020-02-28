using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineFocusGroupDiscussionSubIndicator
    {
        public HssBaselineFocusGroupDiscussionSubIndicator()
        {
            HssBaselineFocusGroupDiscussion = new HashSet<HssBaselineFocusGroupDiscussion>();
        }

        public int SubIndicatorCode { get; set; }
        public int IndicatorCode { get; set; }
        public string SubIndicatorDesc { get; set; }
        public int? MethodCode { get; set; }

        public virtual HssBaselineFocusGroupDiscussionIndicators IndicatorCodeNavigation { get; set; }
        public virtual HssBaselineFocusGroupDiscussionMethod MethodCodeNavigation { get; set; }
        public virtual ICollection<HssBaselineFocusGroupDiscussion> HssBaselineFocusGroupDiscussion { get; set; }
    }
}
