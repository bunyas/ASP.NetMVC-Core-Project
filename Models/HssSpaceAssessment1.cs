using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssSpaceAssessment1
    {
        public HssSpaceAssessment1()
        {
            HssSpaceAssessment2 = new HashSet<HssSpaceAssessment2>();
        }

        public int SpaceAssessment1Code { get; set; }
        public string SpaceAssessment1Desc { get; set; }

        public virtual ICollection<HssSpaceAssessment2> HssSpaceAssessment2 { get; set; }
    }
}
