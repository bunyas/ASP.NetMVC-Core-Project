using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewRptReportingRates1
    {
        public int FacilityCode { get; set; }
        public string EndMonthName { get; set; }
        public DateTime? EndDate { get; set; }
        public int? EndMonth { get; set; }
        public int? EndYear { get; set; }
        public double? ReportsRecieved { get; set; }
        public double? ReportedOnTime { get; set; }
        public double? NoNotReported { get; set; }
        public double? EmergencyOrders { get; set; }
        public string Category { get; set; }
        public string CategoryCode { get; set; }
        public string Facility { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public string ZoneDescription { get; set; }
        public int? CdcregionId { get; set; }
        public string Cdcregion { get; set; }
        public int? ComprehensiveImplimentingPartnerCode { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public string Scto { get; set; }
        public string Indicator { get; set; }
        public double? Value { get; set; }
    }
}
