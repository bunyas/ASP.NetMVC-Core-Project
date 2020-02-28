using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewProcTask
    {
        public string TaskNo { get; set; }
        public int SupplierCode { get; set; }
        public string RfqNo { get; set; }
        public string PflNo { get; set; }
        public int ProductCode { get; set; }
        public string Strength { get; set; }
        public string Packsize { get; set; }
        public int? CartonSizePkt { get; set; }
        public double? CartonWeightKg { get; set; }
        public int? ProductCategory { get; set; }
        public int? RfqQuantity { get; set; }
        public int? PfiQuantity { get; set; }
        public double? PfiPrice { get; set; }
        public int? ProductTypeCode { get; set; }
        public DateTime? DateForwardedToNda { get; set; }
        public DateTime? DateRecievedFromNda { get; set; }
        public bool? PfiAddToOrder { get; set; }
    }
}
