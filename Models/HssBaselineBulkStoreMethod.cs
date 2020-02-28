using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineBulkStoreMethod
    {
        public HssBaselineBulkStoreMethod()
        {
            HssBaselineBulkStoreSubIndicator = new HashSet<HssBaselineBulkStoreSubIndicator>();
        }

        public int MethodCode { get; set; }
        public string MethodDesc { get; set; }

        public virtual ICollection<HssBaselineBulkStoreSubIndicator> HssBaselineBulkStoreSubIndicator { get; set; }
    }
}
