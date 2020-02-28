using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssAreasVisited
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int AreaCode { get; set; }
        public bool? WasVisited { get; set; }
        public string Comment { get; set; }

        public virtual ChssAreas AreaCodeNavigation { get; set; }
        public virtual AFacilities FacilityCodeNavigation { get; set; }
    }
}
