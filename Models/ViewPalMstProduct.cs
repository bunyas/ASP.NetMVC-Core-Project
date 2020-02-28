using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewPalMstProduct
    {
        public int ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int? ProductCategory { get; set; }
        public string CategoryDesc { get; set; }
        public short? BasicUnit { get; set; }
        public int? ProductStatusId { get; set; }
        public string ProductStatus { get; set; }
        public int? ProductTypeId { get; set; }
        public string ProductType { get; set; }
        public int? ArtProductClassification { get; set; }
        public bool? TracerCommodity { get; set; }
        public bool? ProductExpires { get; set; }
        public string Packsize { get; set; }
    }
}
