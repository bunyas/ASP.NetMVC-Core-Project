using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class WebTemplateRutf
    {
        public int ItemNumber { get; set; }
        public int? ProductCode { get; set; }
        public string ItemDescription { get; set; }
        public string BasicUnit { get; set; }
        public double? OpeningBalance { get; set; }
        public double? QuantityReceived { get; set; }
        public double? Consumption { get; set; }
        public double? LossesAdjustments { get; set; }
        public double? ClosingBalance { get; set; }
        public double? QuantityRequired { get; set; }
        public string Notes { get; set; }
        public double? QuantityAllocated { get; set; }
        public string Rfsonotes { get; set; }
    }
}
