using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisConArvA
    {
        public DateTime EndDate { get; set; }
        public int? XMonth { get; set; }
        public int? XYear { get; set; }
        public int DrugCode { get; set; }
        public double? Consumption { get; set; }
        public string ProductDescription { get; set; }
    }
}
