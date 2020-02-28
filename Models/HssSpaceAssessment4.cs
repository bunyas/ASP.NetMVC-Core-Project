using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssSpaceAssessment4
    {
        public int SpaceAssessment2Code { get; set; }
        public int SpaceAssessment3Code { get; set; }

        public virtual HssSpaceAssessment2 SpaceAssessment2CodeNavigation { get; set; }
        public virtual HssSpaceAssessment3 SpaceAssessment3CodeNavigation { get; set; }
    }
}
