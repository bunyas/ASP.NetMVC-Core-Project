using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistVehicleInventoryTrackingSafetyEquipment
    {
        public string Registration { get; set; }
        public DateTime DateOfInventory { get; set; }
        public int SafetyEquipmentId { get; set; }

        public virtual DistVehicleInventoryTracking DistVehicleInventoryTracking { get; set; }
        public virtual DistVehicleSafetyEquipment SafetyEquipment { get; set; }
    }
}
