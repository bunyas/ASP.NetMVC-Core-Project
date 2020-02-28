using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineHfService2
    {
        public HssBaselineHfService2()
        {
            HssBaselineHfService = new HashSet<HssBaselineHfService>();
        }

        public int HfService2Code { get; set; }
        public int? HfService1Code { get; set; }
        public string HfService2Desc { get; set; }

        public virtual HssBaselineHfService1 HfService1CodeNavigation { get; set; }
        public virtual ICollection<HssBaselineHfService> HssBaselineHfService { get; set; }
    }
}
