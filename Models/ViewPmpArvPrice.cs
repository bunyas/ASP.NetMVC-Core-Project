using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewPmpArvPrice
    {
        public DateTime PriceDate { get; set; }
        public int ProductCode { get; set; }
        public double? Scms { get; set; }
        public double? Maul { get; set; }
        public double? Gf { get; set; }
    }
}
