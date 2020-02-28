using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDistributionSchedule
    {
        public string FacilityCode { get; set; }
        public DateTime PostingDate { get; set; }
        public int? PostingYear { get; set; }
        public int? PostingMonth { get; set; }
        public int DrugCode { get; set; }
        public double? Quantity { get; set; }
        public double? LsatPurchasePrice { get; set; }
        public string Strength { get; set; }
        public string Packsize { get; set; }
        public int? CartonSizePkt { get; set; }
        public double? CartonWeightKg { get; set; }
        public string Weight { get; set; }
    }
}
