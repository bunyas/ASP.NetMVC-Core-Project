using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDistKpiLogbookA
    {
        public int? XMonth { get; set; }
        public int? XYear { get; set; }
        public string VehicleRegistration { get; set; }
        public int? OrdometerStartMonth { get; set; }
        public int? OrdometerEndMonth { get; set; }
        public int? FuelAdded { get; set; }
        public int? AverageFuelPrice { get; set; }
        public int? DaysWorked { get; set; }
        public DateTime DepartureDate { get; set; }
        public int? OrdometerArrival { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime? TimeArrival { get; set; }
    }
}
