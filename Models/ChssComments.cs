using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssComments
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int ModuleId { get; set; }
        public int SectorId { get; set; }
        public string Comment { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual ChssModule Module { get; set; }
        public virtual ChssModuleSector Sector { get; set; }
    }
}
