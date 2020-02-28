using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisTOrderTAllocatedSmc
    {
        public int ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Packsize { get; set; }
        public string SapCode { get; set; }
        public DateTime EndDate { get; set; }
        public double? QuantityToOrder { get; set; }
        public int? QuantityAllocated { get; set; }
    }
}
