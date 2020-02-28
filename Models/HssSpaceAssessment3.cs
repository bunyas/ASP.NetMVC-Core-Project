using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssSpaceAssessment3
    {
        public HssSpaceAssessment3()
        {
            HssSpaceAssessment = new HashSet<HssSpaceAssessment>();
            HssSpaceAssessment4 = new HashSet<HssSpaceAssessment4>();
        }

        public int SpaceAssessment3Code { get; set; }
        public string SpaceAssessment3Desc { get; set; }

        public virtual ICollection<HssSpaceAssessment> HssSpaceAssessment { get; set; }
        public virtual ICollection<HssSpaceAssessment4> HssSpaceAssessment4 { get; set; }
    }
}
