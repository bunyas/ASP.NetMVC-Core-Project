using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineBulkStoreSubIndicator
    {
        public HssBaselineBulkStoreSubIndicator()
        {
            HssBaselineBulkStore = new HashSet<HssBaselineBulkStore>();
        }

        public int SubIndicatorCode { get; set; }
        public int IndicatorCode { get; set; }
        public string SubIndicatorDesc { get; set; }
        public int? MethodCode { get; set; }

        public virtual HssBaselineBulkStoreIndicators IndicatorCodeNavigation { get; set; }
        public virtual HssBaselineBulkStoreMethod MethodCodeNavigation { get; set; }
        public virtual ICollection<HssBaselineBulkStore> HssBaselineBulkStore { get; set; }
    }
}
