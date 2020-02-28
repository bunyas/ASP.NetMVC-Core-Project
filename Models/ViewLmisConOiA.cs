using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisConOiA
    {
        public int? XMonth { get; set; }
        public int? XYear { get; set; }
        public DateTime EndDate { get; set; }
        public int ProductCode { get; set; }
        public double? Cosumption { get; set; }
        public string ProductDescription { get; set; }
    }
}
