using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistVehicleMaintaince
    {
        public string Registration { get; set; }
        public DateTime DateRecorded { get; set; }
        public int? MileageBefore { get; set; }
        public string WorkPerformed { get; set; }
        public int? MileageNext { get; set; }
        public int? DaysInWorkhop { get; set; }
        public int? ServiceStation { get; set; }
        public int? LabourCost { get; set; }
        public int? CostOfParts { get; set; }
        public int? TotalCost { get; set; }
        public string DriverPermit { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }

        public virtual DistOperatorPermit DriverPermitNavigation { get; set; }
        public virtual DistVehicleInventory RegistrationNavigation { get; set; }
        public virtual DistServiceStation ServiceStationNavigation { get; set; }
    }
}
