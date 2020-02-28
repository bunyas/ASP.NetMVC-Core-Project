using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class MileageForm
    {
        public int DriverVehicleCode { get; set; }
        public DateTime DepartureDate { get; set; }
        public int Location { get; set; }
        public string DepartureTime { get; set; }
        public double? OdometerDepature { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public int? Destination { get; set; }
        public string ArrivalTimeDestination { get; set; }
        public double? OdometerArrival { get; set; }
        public double? TotalDistance { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }

        public virtual UserAccount AddedByNavigation { get; set; }
        public virtual AFacilities DestinationNavigation { get; set; }
        public virtual VehicleDriverAllocation DriverVehicleCodeNavigation { get; set; }
        public virtual UserAccount EditedByNavigation { get; set; }
        public virtual AFacilities LocationNavigation { get; set; }
    }
}
