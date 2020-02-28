using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewOrderTrackingModuleOrderDetails1
    {
        public string OrderNumber { get; set; }
        public int ProductCode { get; set; }
        public double? QuantityRequired { get; set; }
        public double? QuantityAllocated { get; set; }
        public string Notes { get; set; }
        public string Rfsonotes { get; set; }
        public string ProductDescription { get; set; }
        public string Packsize { get; set; }
        public string Strength { get; set; }
        public string SapCode { get; set; }
    }
}
