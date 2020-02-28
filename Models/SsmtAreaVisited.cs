using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SsmtAreaVisited
    {
        public int FacilityId { get; set; }
        public DateTime DateVisited { get; set; }
        public int AreaId { get; set; }
        public bool? Visited { get; set; }

        public virtual SsmtAAreaVisited Area { get; set; }
        public virtual SsmtFacility SsmtFacility { get; set; }
    }
}
