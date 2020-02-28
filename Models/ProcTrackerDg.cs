using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcTrackerDg
    {
        public int ProcTrackerDgId { get; set; }
        public int CommercialInvoiceId { get; set; }
        public DateTime? DateArrivalEntryPort { get; set; }
        public DateTime? DateClearedEntryPort { get; set; }
        public DateTime? DateDeliveredWarehouse { get; set; }
        public double? QuantityRecievedMaul { get; set; }
        public double? QuantityOutstanding { get; set; }
        public int? FitForPurpose { get; set; }
        public int? QualityIssue { get; set; }
        public int? OrderStatus { get; set; }
        public int? Vendor { get; set; }
        public int? Manufacturer { get; set; }
        public int? CountryOrigin { get; set; }
        public string GrnNo { get; set; }
        public DateTime? GrnDate { get; set; }
        public double? GrnQuantity { get; set; }
        public DateTime? GrnDateReceiptWarehouse { get; set; }
        public string QualityIssueDesc { get; set; }

        public virtual ProcTrackerCi CommercialInvoice { get; set; }
    }
}
