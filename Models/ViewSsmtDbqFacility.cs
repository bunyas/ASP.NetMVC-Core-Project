using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewSsmtDbqFacility
    {
        public int DistrictCode { get; set; }
        public int FacilityCode { get; set; }
        public string DistrictName { get; set; }
        public string Facility { get; set; }
        public string LevelOfCare { get; set; }
        public DateTime DateVisit { get; set; }
        public DateTime? DateNextVisit { get; set; }
        public bool? AccreditedArt { get; set; }
        public bool? ReadinessArt { get; set; }
        public string SiteVolumeDesc { get; set; }
        public string SsmtsDesc { get; set; }
    }
}
