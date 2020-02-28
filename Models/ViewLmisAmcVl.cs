using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisAmcVl
    {
        public int? DeliveryZoneCode { get; set; }
        public string Facility { get; set; }
        public int ProductCode { get; set; }
        public DateTime EndDate { get; set; }
        public int? EndYear { get; set; }
        public int? EndMonth { get; set; }
        public string EndMonthName { get; set; }
        public string OrderNumber { get; set; }
        public double? Consumption { get; set; }
        public int? ComprehensiveImplimentingPartnerCode { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public int? CdcregionId { get; set; }
        public string Cdcregion { get; set; }
        public string ZoneDescription { get; set; }
        public int FacilityCode { get; set; }
        public string Scto { get; set; }
        public int ProductCategory { get; set; }
    }
}
