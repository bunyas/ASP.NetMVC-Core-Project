using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcTask
    {
        public ProcTask()
        {
            ProcTaskDetail = new HashSet<ProcTaskDetail>();
        }

        public string RfqNo { get; set; }
        public int SupplierCode { get; set; }
        public string TaskNo { get; set; }
        public string PflNo { get; set; }
        public string OrderNo { get; set; }
        public bool? IsOrderApproved { get; set; }
        public int? OrderStatus { get; set; }
        public string AddedBy { get; set; }
        public DateTime? DateAdded { get; set; }
        public string EditedBy { get; set; }
        public DateTime? DateEdited { get; set; }
        public DateTime? DateForwardedToNda { get; set; }
        public DateTime? DateRecievedFromNda { get; set; }
        public DateTime? OrderConfirmationDate { get; set; }

        public virtual ProcOrderStatus OrderStatusNavigation { get; set; }
        public virtual ASupplier SupplierCodeNavigation { get; set; }
        public virtual ProcTaskHeader TaskNoNavigation { get; set; }
        public virtual ICollection<ProcTaskDetail> ProcTaskDetail { get; set; }
    }
}
