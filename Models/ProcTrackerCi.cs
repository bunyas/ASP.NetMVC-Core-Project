using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcTrackerCi
    {
        public ProcTrackerCi()
        {
            ProcTrackerDg = new HashSet<ProcTrackerDg>();
        }

        public int CommercialInvoiceId { get; set; }
        public int? AwardId { get; set; }
        public DateTime? DateShippingDocumentsSentMaul { get; set; }
        public string InvoiceNo { get; set; }
        public double? InvoiceValue { get; set; }
        public DateTime? InvoiceDate { get; set; }

        public virtual ProcTrackerAwardPfi Award { get; set; }
        public virtual ICollection<ProcTrackerDg> ProcTrackerDg { get; set; }
    }
}
