using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewOrderLabProductcode
    {
        public string OrderNumber { get; set; }
        public int? ProductCode { get; set; }
        public double? QuantityToOrder { get; set; }
        public int? QuantityAllocated { get; set; }
        public string Comments { get; set; }
        public string Rfsonotes { get; set; }
    }
}
