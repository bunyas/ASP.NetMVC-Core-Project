using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDistKpiGraphMonthB
    {
        public int? CopYear { get; set; }
        public int QuarterId { get; set; }
        public int? XYear { get; set; }
        public int? XMonth { get; set; }
        public int? VehicleClassificationId { get; set; }
        public int? KpiKilometersTravelled { get; set; }
        public double? KpiFuelConsumption { get; set; }
        public double? KpiRunningCostPerKm { get; set; }
        public double? KpiAvialability { get; set; }
        public double? KpiUtilization { get; set; }
        public int? Vehicles { get; set; }
    }
}
