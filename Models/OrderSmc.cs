using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class OrderSmc
    {
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ItemCode { get; set; }
        public double? OpeningBalance { get; set; }
        public double? QuantityRecieved { get; set; }
        public double? Consumption { get; set; }
        public double? LossAdjustment { get; set; }
        public double? ClosingBalance { get; set; }
        public double? QuantityToOrder { get; set; }
        public int? QuantityAllocated { get; set; }
        public string Comment { get; set; }

        public virtual AProduct ItemCodeNavigation { get; set; }
        public virtual OrderSmcHeader OrderSmcHeader { get; set; }
    }
}
