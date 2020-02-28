using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisAllocationNViralLoad
    {
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? DatePrepared { get; set; }
        public int ProductCode { get; set; }
        public double? OpeningBalance { get; set; }
        public double? QuantityRecieved { get; set; }
        public double? Consumption { get; set; }
        public double? LossesAndAdjustments { get; set; }
        public double? TotalClosingBalance { get; set; }
        public double? QuantityOrdered { get; set; }
        public string Comment { get; set; }
        public double? QuantityAllocated { get; set; }
        public string Rfsonotes { get; set; }
        public string OrderNumber { get; set; }
        public int? OrderTypeId { get; set; }
        public int? OrderStatusId { get; set; }
        public bool? EmergencyOrder { get; set; }
        public bool? FinalSubmission { get; set; }
        public string Facility { get; set; }
    }
}
