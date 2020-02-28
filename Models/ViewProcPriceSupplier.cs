using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewProcPriceSupplier
    {
        public int? ProductCategory { get; set; }
        public int ProductCode { get; set; }
        public string Packsize { get; set; }
        public string Strength { get; set; }
        public int? SupplierCode { get; set; }
        public DateTime? PriceDate { get; set; }
        public double? Price { get; set; }
        public bool? RecordStatus { get; set; }
    }
}
