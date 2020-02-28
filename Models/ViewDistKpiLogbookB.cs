using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDistKpiLogbookB
    {
        public int? XMonth { get; set; }
        public int? XYear { get; set; }
        public DateTime DepartureDate { get; set; }
        public string VehicleRegistration { get; set; }
        public int? OrdometerEndMonth { get; set; }
        public int? FuelAdded { get; set; }
        public int? AverageFuelPrice { get; set; }
        public int? DaysWorked { get; set; }
        public int? MaintenanceCost { get; set; }
        public int? DaysInWorkshop { get; set; }
        public int? OrdometerStartMonth { get; set; }
        public int? WorkingDaysMonth { get; set; }
        public int? NoIncidents { get; set; }
    }
}
