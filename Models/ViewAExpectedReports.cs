using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewAExpectedReports
    {
        public int? DeliveryZoneCode { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public int? DistrrictCode { get; set; }
        public int? LevelOfCare { get; set; }
        public int FacilityCode { get; set; }
        public string Facility { get; set; }
        public bool? Arv { get; set; }
        public bool? Testkits { get; set; }
        public bool? Smc { get; set; }
        public bool? Laboratory { get; set; }
    }
}
