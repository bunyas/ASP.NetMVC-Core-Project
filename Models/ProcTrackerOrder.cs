using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcTrackerOrder
    {
        public ProcTrackerOrder()
        {
            ProcTrackerGrn = new HashSet<ProcTrackerGrn>();
            ProcTrackerInvoice = new HashSet<ProcTrackerInvoice>();
            ProcTrackerPfi = new HashSet<ProcTrackerPfi>();
            ProcTrackerProductDetail = new HashSet<ProcTrackerProductDetail>();
        }

        public string PurchaseOrderNo { get; set; }
        public int SupplierId { get; set; }
        public string TaskOrderNo { get; set; }
        public DateTime? OrderConfirmationDate { get; set; }
        public int? OrderClassificationCode { get; set; }

        public virtual ProcTrackerOrderClassification OrderClassificationCodeNavigation { get; set; }
        public virtual ICollection<ProcTrackerGrn> ProcTrackerGrn { get; set; }
        public virtual ICollection<ProcTrackerInvoice> ProcTrackerInvoice { get; set; }
        public virtual ICollection<ProcTrackerPfi> ProcTrackerPfi { get; set; }
        public virtual ICollection<ProcTrackerProductDetail> ProcTrackerProductDetail { get; set; }
    }
}
