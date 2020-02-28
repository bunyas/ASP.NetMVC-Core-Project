using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class TmpMosAllproducts
    {
        public DateTime ReportingPeriod { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public double? Amc { get; set; }
        public decimal? StockOnHand { get; set; }
        public decimal? QuantityOnOrder { get; set; }
        public decimal? MoS { get; set; }
        public decimal? OnOrder { get; set; }
    }
}
