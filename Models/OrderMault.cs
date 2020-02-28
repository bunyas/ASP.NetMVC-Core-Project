using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class OrderMault
    {
        public string OrderNumber { get; set; }
        public int ProductCode { get; set; }
        public double? QuantityRequired { get; set; }
        public double? QuantityAllocated { get; set; }
        public string Rfsonotes { get; set; }
        public string Notes { get; set; }

        public virtual OrderMaultHeader OrderNumberNavigation { get; set; }
        public virtual AProduct ProductCodeNavigation { get; set; }
    }
}
