using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoSsmtSupervisor
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int CpCdoe { get; set; }

        public virtual FoSsmtFacility FoSsmtFacility { get; set; }
    }
}
