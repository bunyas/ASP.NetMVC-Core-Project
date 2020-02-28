using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewProcOrders
    {
        public string RfqNo { get; set; }
        public int SupplierCode { get; set; }
        public string TaskNo { get; set; }
        public string PflNo { get; set; }
        public string OrderNo { get; set; }
        public bool? IsOrderApproved { get; set; }
        public DateTime? DateForwardedToNda { get; set; }
        public DateTime? DateRecievedFromNda { get; set; }
        public DateTime? OrderConfirmationDate { get; set; }
        public int ProductCode { get; set; }
        public int? ProductTypeCode { get; set; }
        public bool? PfiAddToOrder { get; set; }
        public int? RfqQuantity { get; set; }
        public int? PfiQuantity { get; set; }
        public double? PfiPrice { get; set; }
        public int? OrderQuanity { get; set; }
        public DateTime? OrderDueDate { get; set; }
        public DateTime? DateOfOrderArrival { get; set; }
        public DateTime? DateOrderClearanceCustoms { get; set; }
        public int? QuantityRecieved { get; set; }
        public int? QuantityOutstanding { get; set; }
        public string Commments { get; set; }
        public double? FobPrice { get; set; }
        public double? CifPrice { get; set; }
    }
}
