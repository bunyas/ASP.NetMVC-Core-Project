using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewSsmtFacilityExport
    {
        public bool? CheckBox { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public string DistrictName { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public string LevelOfCare { get; set; }
        public string Facility { get; set; }
        public int DistrictCode { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public int LevelOfCareCode { get; set; }
        public int FacilityCode { get; set; }
        public string SapCode { get; set; }
        public bool? SupportedByMaul { get; set; }
        public bool? IsAccredited { get; set; }
        public int? ClientTypeCode { get; set; }
        public int? RegionCode { get; set; }
    }
}
