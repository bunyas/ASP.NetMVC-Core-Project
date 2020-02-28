using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistLocation
    {
        public DistLocation()
        {
            DistAssessmentResultHeader = new HashSet<DistAssessmentResultHeader>();
            DistOperatorPersonal = new HashSet<DistOperatorPersonal>();
            DistVehicleInventoryTrackingAllocatedNavigation = new HashSet<DistVehicleInventoryTracking>();
            DistVehicleInventoryTrackingVehicleBasedNavigation = new HashSet<DistVehicleInventoryTracking>();
        }

        public int LocationCode { get; set; }
        public string Location { get; set; }

        public virtual ICollection<DistAssessmentResultHeader> DistAssessmentResultHeader { get; set; }
        public virtual ICollection<DistOperatorPersonal> DistOperatorPersonal { get; set; }
        public virtual ICollection<DistVehicleInventoryTracking> DistVehicleInventoryTrackingAllocatedNavigation { get; set; }
        public virtual ICollection<DistVehicleInventoryTracking> DistVehicleInventoryTrackingVehicleBasedNavigation { get; set; }
    }
}
