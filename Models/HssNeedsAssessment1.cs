using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssNeedsAssessment1
    {
        public HssNeedsAssessment1()
        {
            HssNeedsAssessment2 = new HashSet<HssNeedsAssessment2>();
        }

        public int HssNeedsAssessment1Code { get; set; }
        public string HssNeedsAssessment1Desc { get; set; }

        public virtual ICollection<HssNeedsAssessment2> HssNeedsAssessment2 { get; set; }
    }
}
