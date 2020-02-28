using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewProcPriceSupplierRStatus
    {
        public DateTime PriceDate { get; set; }
        public int ProductCode { get; set; }
        public int SupplierCode { get; set; }
        public int? PDay { get; set; }
        public int? PMonth { get; set; }
        public int? PYear { get; set; }
        public bool RecordStatus { get; set; }
        public double? Price { get; set; }
    }
}
