using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewPalConsumption
    {
        public string SapCode { get; set; }
        public string ProductCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double? Consumption { get; set; }
    }
}
