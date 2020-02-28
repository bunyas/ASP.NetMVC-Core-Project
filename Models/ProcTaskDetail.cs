using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcTaskDetail
    {
        public ProcTaskDetail()
        {
            ProcTaskOrderDetail = new HashSet<ProcTaskOrderDetail>();
        }

        public string RfqNo { get; set; }
        public int SupplierCode { get; set; }
        public int ProductCode { get; set; }
        public int? ProductTypeCode { get; set; }
        public bool? PfiAddToOrder { get; set; }
        public int? RfqQuantity { get; set; }
        public int? PfiQuantity { get; set; }
        public double? PfiPrice { get; set; }
        public int? OrderQuanity { get; set; }
        public double? FobPrice { get; set; }
        public double? CifPrice { get; set; }
        public int? QuantityRecieved { get; set; }
        public int? QuantityOutstanding { get; set; }
        public string Commments { get; set; }

        public virtual ProcTask ProcTask { get; set; }
        public virtual ProcProductType ProductTypeCodeNavigation { get; set; }
        public virtual ICollection<ProcTaskOrderDetail> ProcTaskOrderDetail { get; set; }
    }
}
