using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistVehicleAuthorization
    {
        public string OperatorPermit { get; set; }
        public DateTime DateOfAuthorization { get; set; }
        public string VehicleRegistartion { get; set; }
        public int? Destination { get; set; }
        public string PurposeOfTrip { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? LineManager { get; set; }
        public int? AdministationManager { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }

        public virtual DistVehicleInventory VehicleRegistartionNavigation { get; set; }
    }
}
