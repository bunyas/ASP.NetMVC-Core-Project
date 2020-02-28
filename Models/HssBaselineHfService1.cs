using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineHfService1
    {
        public HssBaselineHfService1()
        {
            HssBaselineHfService2 = new HashSet<HssBaselineHfService2>();
        }

        public int HfService1Code { get; set; }
        public string HfService1Desc { get; set; }

        public virtual ICollection<HssBaselineHfService2> HssBaselineHfService2 { get; set; }
    }
}
