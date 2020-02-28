using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistVehicleSafetyEquipment
    {
        public DistVehicleSafetyEquipment()
        {
            DistVehicleInventoryTracking = new HashSet<DistVehicleInventoryTracking>();
            DistVehicleInventoryTrackingSafetyEquipment = new HashSet<DistVehicleInventoryTrackingSafetyEquipment>();
        }

        public int EquipmentCode { get; set; }
        public string Equipment { get; set; }

        public virtual ICollection<DistVehicleInventoryTracking> DistVehicleInventoryTracking { get; set; }
        public virtual ICollection<DistVehicleInventoryTrackingSafetyEquipment> DistVehicleInventoryTrackingSafetyEquipment { get; set; }
    }
}
