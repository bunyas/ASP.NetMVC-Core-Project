using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineLmisSubIndicator
    {
        public HssBaselineLmisSubIndicator()
        {
            HssBaselineLmis = new HashSet<HssBaselineLmis>();
        }

        public int SubIndicatorCode { get; set; }
        public int IndicatorCode { get; set; }
        public string SubIndicatorDesc { get; set; }
        public int? MethodCode { get; set; }

        public virtual HssBaselineLmisIndicators IndicatorCodeNavigation { get; set; }
        public virtual HssBaselineLmisMethod MethodCodeNavigation { get; set; }
        public virtual ICollection<HssBaselineLmis> HssBaselineLmis { get; set; }
    }
}
