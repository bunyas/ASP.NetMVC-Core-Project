using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewSapXSmc2
    {
        public long? FacilityCount { get; set; }
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? DatePrepared { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public int? DistrrictCode { get; set; }
        public string Facility { get; set; }
        public string SapCode { get; set; }
    }
}
