using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewProcTracker
    {
        public string TaskNo { get; set; }
        public int ProductCode { get; set; }
        public string Strength { get; set; }
        public short? BasicUnit { get; set; }
        public string Packsize { get; set; }
        public int SupplierCode { get; set; }
        public int? OrderQuanity { get; set; }
        public double? FobPrice { get; set; }
        public double? CifPrice { get; set; }
        public DateTime? OrderDueDate { get; set; }
        public string PflNo { get; set; }
        public DateTime? DateForwardedToNda { get; set; }
        public DateTime? DateRecievedFromNda { get; set; }
        public DateTime? OrderConfirmationDate { get; set; }
        public string OrderNo { get; set; }
        public DateTime? DateOfOrderArrival { get; set; }
        public DateTime? DateOrderClearanceCustoms { get; set; }
        public int? QuantityRecieved { get; set; }
        public int? QuantityOutstanding { get; set; }
        public string Commments { get; set; }
        public DateTime? StartOfPeriod { get; set; }
        public DateTime? EndOfPeriod { get; set; }
        public int? ProductTypeCode { get; set; }
        public int? ProductCategory { get; set; }
    }
}
