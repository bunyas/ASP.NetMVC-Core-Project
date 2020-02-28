using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewMileageForm
    {
        public int Location { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string DepartureTime { get; set; }
        public double? OdometerDepature { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public double? OdometerArrival { get; set; }
        public string DriverPermit { get; set; }
        public string VehicleNumber { get; set; }
        public int? Destination { get; set; }
        public string ArrivalTimeDestination { get; set; }
        public double? TotalDistance { get; set; }
        public int? DeliveryZone { get; set; }
    }
}
