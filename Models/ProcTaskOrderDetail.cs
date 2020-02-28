using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcTaskOrderDetail
    {
        public string RfqNo { get; set; }
        public int SupplierCode { get; set; }
        public int ProductCode { get; set; }
        public DateTime OrderDueDate { get; set; }
        public DateTime? DateOfOrderArrival { get; set; }
        public DateTime? DateOrderClearanceCustoms { get; set; }
        public int? QuantityRecieved { get; set; }
        public int? QuantityOutstanding { get; set; }
        public string Commments { get; set; }

        public virtual ProcTaskDetail ProcTaskDetail { get; set; }
    }
}
