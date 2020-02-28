using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewConsumptionSmc
    {
        public int FacilityCode { get; set; }
        public int? BYear { get; set; }
        public int? BMonth { get; set; }
        public int ItemCode { get; set; }
        public double? Consumption { get; set; }
    }
}
