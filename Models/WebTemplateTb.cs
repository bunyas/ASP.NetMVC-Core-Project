using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class WebTemplateTb
    {
        public int ItemNumber { get; set; }
        public int? SectionNumber { get; set; }
        public int? ProductCode { get; set; }
        public string Description { get; set; }
        public string PackSize { get; set; }
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
    }
}
