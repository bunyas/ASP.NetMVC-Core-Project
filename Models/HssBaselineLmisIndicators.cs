using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineLmisIndicators
    {
        public HssBaselineLmisIndicators()
        {
            HssBaselineLmisSubIndicator = new HashSet<HssBaselineLmisSubIndicator>();
        }

        public int IndicatorCode { get; set; }
        public string IndicatorDesc { get; set; }

        public virtual ICollection<HssBaselineLmisSubIndicator> HssBaselineLmisSubIndicator { get; set; }
    }
}
