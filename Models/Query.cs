using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class Query
    {
        public double? ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Strength { get; set; }
        public string Packsize { get; set; }
        public double? CartonSizePkt { get; set; }
        public double? CartonWeightKg { get; set; }
        public double? ProductCategory { get; set; }
        public double? BasicUnit { get; set; }
        public double? ApprovedMohNtg { get; set; }
        public double? ApprovedWho { get; set; }
        public double? ApprovedFda { get; set; }
        public double? NdaRegistration { get; set; }
        public string SapCode { get; set; }
        public double? ConsummableProduct { get; set; }
        public double? ArtProductClassification { get; set; }
    }
}
