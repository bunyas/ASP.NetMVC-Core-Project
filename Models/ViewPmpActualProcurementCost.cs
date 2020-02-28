using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewPmpActualProcurementCost
    {
        public DateTime OrderDueDate { get; set; }
        public double? FobPrice { get; set; }
        public double? ScmsPrice { get; set; }
        public int ProductCode { get; set; }
        public string PurchaseOrderNo { get; set; }
        public double PriceVariance { get; set; }
    }
}
