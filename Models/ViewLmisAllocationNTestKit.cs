using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisAllocationNTestKit
    {
        public int FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DatePrepared { get; set; }
        public int ItemCode { get; set; }
        public double? NoTestStart2months { get; set; }
        public double? TestRecieved2months { get; set; }
        public double? TestUsed2months { get; set; }
        public double? LossAdjustment { get; set; }
        public double? TestRemaining { get; set; }
        public double? MaximumStock { get; set; }
        public double? QunatityOnOrder { get; set; }
        public double? QuantityRequired { get; set; }
        public string QuantityToShip { get; set; }
        public int? QuantityAllocated { get; set; }
        public string Rfsonotes { get; set; }
        public double? DaysOutOfStockDuring2Months { get; set; }
        public double? AdjustedAmc { get; set; }
        public string Notes { get; set; }
        public string OrderNumber { get; set; }
        public int? OrderTypeId { get; set; }
        public int? OrderStatusId { get; set; }
        public bool? EmergencyOrder { get; set; }
        public string Facility { get; set; }
    }
}
