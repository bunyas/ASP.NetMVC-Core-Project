using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class Inventory
    {
        public int ItemCode { get; set; }
        public int SupplierCode { get; set; }
        public int ManufacturerCode { get; set; }
        public DateTime DateSupplied { get; set; }
        public int? QuantitySupplied { get; set; }
        public int? CurrentBalance { get; set; }
        public bool? InStock { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
    }
}
