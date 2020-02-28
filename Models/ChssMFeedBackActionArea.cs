using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssMFeedBackActionArea
    {
        public int FacilityCode { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public string ImplimentingPartnerDescription { get; set; }
        public int? DistrrictCode { get; set; }
        public string DistrictName { get; set; }
        public int? LevelOfCare { get; set; }
        public string LevelDesc { get; set; }
        public int? CdcregionId { get; set; }
        public string Cdcregion { get; set; }
        public int? ComprehensiveImplimentingPartnerCode { get; set; }
        public string ComprehensiveImplimentingPartnerDescription { get; set; }
        public string Scto { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int ActionCode { get; set; }
        public int SectorId { get; set; }
        public string SectorDesc { get; set; }
        public int ModuleId { get; set; }
        public string ModuleDesc { get; set; }
        public string CorrectionArea { get; set; }
        public string Mitigation { get; set; }
        public string ActionOwner { get; set; }
        public string TimeLine { get; set; }
    }
}
