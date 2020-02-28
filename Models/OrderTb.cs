using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class OrderTb
    {
        public string OrderNumber { get; set; }
        public int ProductCode { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double? OpeningBalance { get; set; }
        public double? QtyRecieved { get; set; }
        public double? Dispensed2MonthsReview { get; set; }
        public double? LossesAndAdjustments { get; set; }
        public double? TotalClosingBalance { get; set; }
        public double? DaysOutofStock { get; set; }
        public double? AdjustedAmc { get; set; }
        public double? ClosingBalance { get; set; }
        public double? MonthsOfStock { get; set; }
        public double? QuantityAllocated { get; set; }
        public string Comments { get; set; }
        public string Rfsonotes { get; set; }
        public double? QuantityRequired { get; set; }

        public virtual OrderTbHeader OrderNumberNavigation { get; set; }
        public virtual AProduct ProductCodeNavigation { get; set; }
    }
}
