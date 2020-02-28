using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineLmisMethod
    {
        public HssBaselineLmisMethod()
        {
            HssBaselineLmisSubIndicator = new HashSet<HssBaselineLmisSubIndicator>();
        }

        public int MethodCode { get; set; }
        public string MethodDesc { get; set; }

        public virtual ICollection<HssBaselineLmisSubIndicator> HssBaselineLmisSubIndicator { get; set; }
    }
}
