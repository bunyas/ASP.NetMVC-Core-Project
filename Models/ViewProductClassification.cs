using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewProductClassification
    {
        public int ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Strength { get; set; }
        public string Packsize { get; set; }
        public int? CartonSizePkt { get; set; }
        public short? BasicUnit { get; set; }
        public string Classification { get; set; }
        public string ProductType { get; set; }
        public int? ProductCategory { get; set; }
    }
}
