using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcPriceSupplier
    {
        public DateTime PriceDate { get; set; }
        public int ProductCode { get; set; }
        public int SupplierCode { get; set; }
        public double? Price { get; set; }
        public bool RecordStatus { get; set; }

        public virtual AProduct ProductCodeNavigation { get; set; }
    }
}
