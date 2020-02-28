using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewWebTemplateArvReportHeader
    {
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Facility { get; set; }
        public string DistrictName { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public DateTime? DatePrepared { get; set; }
        public string OrderNumber { get; set; }
        public int? OrderTypeId { get; set; }
        public int? OrderStatusId { get; set; }
        public string Status { get; set; }
        public string OrderType { get; set; }
        public bool? FinalSubmission { get; set; }
        public DateTime? DateExpected { get; set; }
    }
}
