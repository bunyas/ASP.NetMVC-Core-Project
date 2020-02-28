using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class TmpMosTracer
    {
        public DateTime ReportingPeriod { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public string TracerCommodities { get; set; }
        public double? Amc { get; set; }
        public decimal? StockOnHand { get; set; }
        public decimal? OnOrder { get; set; }
        public decimal? MoSSoH { get; set; }
        public decimal? MoSOrder { get; set; }
    }
}
