using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssNeedsAssessment4
    {
        public int HssNeedsAssessment2Code { get; set; }
        public int HssNeedsAssessment3Code { get; set; }

        public virtual HssNeedsAssessment2 HssNeedsAssessment2CodeNavigation { get; set; }
        public virtual HssNeedsAssessment3 HssNeedsAssessment3CodeNavigation { get; set; }
    }
}
