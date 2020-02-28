using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewSsmtMascisExport
    {
        public string LevelOfCare { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public bool? MyCheck { get; set; }
        public int FacilityId { get; set; }
        public DateTime DateVisit { get; set; }
        public bool? AccreditedArt { get; set; }
        public DateTime? DateNextVisit { get; set; }
        public bool? ReadinessArt { get; set; }
        public int? SiteVolume { get; set; }
        public string VisitMajorIssue { get; set; }
        public int? Ssmts { get; set; }
        public int? DistrrictCode { get; set; }
    }
}
