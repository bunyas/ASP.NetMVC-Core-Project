using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewPalProducts
    {
        public int CategoryCode { get; set; }
        public string CategoryDesc { get; set; }
        public int ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Strength { get; set; }
        public int? CartonSizePkt { get; set; }
        public double? CartonWeightKg { get; set; }
        public int? ProductCategory { get; set; }
        public short? BasicUnit { get; set; }
        public bool? ApprovedMohNtg { get; set; }
        public bool? ApprovedWho { get; set; }
        public bool? ApprovedFda { get; set; }
        public int? NdaRegistration { get; set; }
        public string SapCode { get; set; }
        public bool? ConsummableProduct { get; set; }
        public int? ArtProductClassification { get; set; }
    }
}
