using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewPmpStockOutRate
    {
        public int? FacilityCode { get; set; }
        public double ClosingBalance { get; set; }
        public double Consumption { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
