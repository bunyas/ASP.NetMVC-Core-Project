using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssFeedBackActionArea
    {
        public int ActionCode { get; set; }
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int SectorId { get; set; }
        public string CorrectionArea { get; set; }
        public string Mitigation { get; set; }
        public string ActionOwner { get; set; }
        public string TimeLine { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual ChssModuleSector Sector { get; set; }
    }
}
