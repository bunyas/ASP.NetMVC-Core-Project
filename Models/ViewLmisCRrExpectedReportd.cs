using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisCRrExpectedReportd
    {
        public int FacilityCode { get; set; }
        public DateTime EndDate { get; set; }
        public string Facility { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public string ZoneDescription { get; set; }
        public int? CdcregionId { get; set; }
        public string Cdcregion { get; set; }
        public int? ComprehensiveImplimentingPartnerCode { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public string Scto { get; set; }
    }
}
