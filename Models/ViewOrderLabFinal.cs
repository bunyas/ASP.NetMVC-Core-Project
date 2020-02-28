using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewOrderLabFinal
    {
        public string Facility { get; set; }
        public int ProductCode { get; set; }
        public string SapCode { get; set; }
        public string OrderNumber { get; set; }
        public int FacilityCode { get; set; }
        public DateTime? DateCompleted { get; set; }
        public int? OrderTypeId { get; set; }
        public int? OrderStatusId { get; set; }
        public int ItemCode { get; set; }
        public double? OpeningBalance { get; set; }
        public double? QuantityRecieved { get; set; }
        public double? Consumption { get; set; }
        public double? LossesAdjustment { get; set; }
        public double? ClosingBalance { get; set; }
        public double? QuantityToOrder { get; set; }
        public int? QuantityAllocated { get; set; }
        public double? TotalCost { get; set; }
    }
}
