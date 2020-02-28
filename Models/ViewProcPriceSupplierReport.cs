using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewProcPriceSupplierReport
    {
        public int SupplierCode { get; set; }
        public int? PriceYear { get; set; }
        public int? ProductCategory { get; set; }
        public int ProductCode { get; set; }
        public string Strength { get; set; }
        public string Packsize { get; set; }
        public double? January { get; set; }
        public double? February { get; set; }
        public double? March { get; set; }
        public double? April { get; set; }
        public double? May { get; set; }
        public double? June { get; set; }
        public double? July { get; set; }
        public double? August { get; set; }
        public double? September { get; set; }
        public double? October { get; set; }
        public double? November { get; set; }
        public double? December { get; set; }
    }
}
