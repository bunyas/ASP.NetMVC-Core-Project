using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class OrderLab
    {
        public string OrderNumber { get; set; }
        public int ItemCode { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double? OpeningBalance { get; set; }
        public double? QuantityRecieved { get; set; }
        public double? Consumption { get; set; }
        public double? LossesAdjustment { get; set; }
        public double? ClosingBalance { get; set; }
        public double? QuantityToOrder { get; set; }
        public int? QuantityAllocated { get; set; }
        public double? TotalCost { get; set; }
        public string Comments { get; set; }
        public string Rfsonotes { get; set; }

        public virtual AProductLabCategory ItemCodeNavigation { get; set; }
        public virtual OrderLabHeader OrderNumberNavigation { get; set; }
    }
}
