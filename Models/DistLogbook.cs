using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistLogbook
    {
        public string VehicleRegistration { get; set; }
        public DateTime DepartureDate { get; set; }
        public string DriverPermit { get; set; }
        public DateTime TimeStart { get; set; }
        public int? SourceFacility { get; set; }
        public int? SourceOther { get; set; }
        public int? DestinationFacility { get; set; }
        public int? DestinationOther { get; set; }
        public int? OrdometerStart { get; set; }
        public int? OrdometerArrival { get; set; }
        public int? DistanceTravelled { get; set; }
        public DateTime? TimeArrival { get; set; }
        public int? FuelAdded { get; set; }
        public int? FuelUnitCost { get; set; }
        public string Passengers { get; set; }
        public int? Remarks { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public string Comment { get; set; }

        public virtual AFacilities DestinationFacilityNavigation { get; set; }
        public virtual DistOperatorPermit DriverPermitNavigation { get; set; }
        public virtual AFacilities SourceFacilityNavigation { get; set; }
        public virtual DistVehicleInventory VehicleRegistrationNavigation { get; set; }
    }
}
