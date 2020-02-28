using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDistPackingList
    {
        public int FacilityCode { get; set; }
        public int DrugCode { get; set; }
        public double? Quantity { get; set; }
        public DateTime PostingDate { get; set; }
        public double? CartonWeightKg { get; set; }
        public int? CartonSizePkt { get; set; }
        public int? ProductCategory { get; set; }
        public string Packsize { get; set; }
        public double? Cartons { get; set; }
        public int? DeliveryZoneCode { get; set; }
    }
}
