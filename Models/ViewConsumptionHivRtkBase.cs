using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewConsumptionHivRtkBase
    {
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int ItemCode { get; set; }
        public double? TestUsed2months { get; set; }
    }
}
