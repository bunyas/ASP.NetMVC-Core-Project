using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcTrackerInvoice
    {
        public string InvoiceNo { get; set; }
        public int SupplierCode { get; set; }
        public string PurchaseOrderNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public double? InvoiceValue { get; set; }

        public virtual ProcTrackerOrder ProcTrackerOrder { get; set; }
    }
}
