using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class PackingList
    {
        public string FacilityCode { get; set; }
        public DateTime PostingDate { get; set; }
        public int DrugCode { get; set; }
        public string BatchNo { get; set; }
        public double? Quantity { get; set; }
        public double? LsatPurchasePrice { get; set; }
        public string Currency { get; set; }
        public double? Price { get; set; }
        public double? LineTotal { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
