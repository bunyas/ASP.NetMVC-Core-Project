using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistVehicleInventoryTracking
    {
        public DistVehicleInventoryTracking()
        {
            DistVehicleInventoryTrackingSafetyEquipment = new HashSet<DistVehicleInventoryTrackingSafetyEquipment>();
            DistVehicleInventoryTrackingSecuritySystem = new HashSet<DistVehicleInventoryTrackingSecuritySystem>();
        }

        public string Registration { get; set; }
        public DateTime DateOfInventory { get; set; }
        public int? Condition { get; set; }
        public int? VehicleBased { get; set; }
        public int? Allocated { get; set; }
        public int? MajorUse { get; set; }
        public double? TotalKilometers { get; set; }
        public double? TotalKmPerMonth { get; set; }
        public double? AvgDaysInUseMonth { get; set; }
        public int? MainOperator { get; set; }
        public int? SecuritySystem { get; set; }
        public int? SafetyEquipment { get; set; }
        public bool? RecordStatus { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }

        public virtual DistLocation AllocatedNavigation { get; set; }
        public virtual DistVehicleCondition ConditionNavigation { get; set; }
        public virtual DistJobTitle MainOperatorNavigation { get; set; }
        public virtual DistVehicleMajorUse MajorUseNavigation { get; set; }
        public virtual DistVehicleInventory RegistrationNavigation { get; set; }
        public virtual DistVehicleSafetyEquipment SafetyEquipmentNavigation { get; set; }
        public virtual DistLocation VehicleBasedNavigation { get; set; }
        public virtual ICollection<DistVehicleInventoryTrackingSafetyEquipment> DistVehicleInventoryTrackingSafetyEquipment { get; set; }
        public virtual ICollection<DistVehicleInventoryTrackingSecuritySystem> DistVehicleInventoryTrackingSecuritySystem { get; set; }
    }
}
