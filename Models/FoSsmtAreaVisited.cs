using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoSsmtAreaVisited
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int AreaCode { get; set; }
        public bool? WasVisited { get; set; }
        public string Comment { get; set; }

        public virtual FoSsmtArea AreaCodeNavigation { get; set; }
        public virtual FoSsmtFacility FoSsmtFacility { get; set; }
    }
}
