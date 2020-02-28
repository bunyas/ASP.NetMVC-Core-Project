using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistVehicleInventory
    {
        public DistVehicleInventory()
        {
            DistIncidentReport = new HashSet<DistIncidentReport>();
            DistIncidentReportOtherVehicle = new HashSet<DistIncidentReportOtherVehicle>();
            DistLogbook = new HashSet<DistLogbook>();
            DistVehicleAuthorization = new HashSet<DistVehicleAuthorization>();
            DistVehicleCheckDefectReport = new HashSet<DistVehicleCheckDefectReport>();
            DistVehicleCheckRecommendation = new HashSet<DistVehicleCheckRecommendation>();
            DistVehicleInventoryTracking = new HashSet<DistVehicleInventoryTracking>();
            DistVehicleMaintaince = new HashSet<DistVehicleMaintaince>();
        }

        public string Registration { get; set; }
        public int? Make { get; set; }
        public int? Model { get; set; }
        public string EngineSize { get; set; }
        public string EngineNo { get; set; }
        public string ChassisNo { get; set; }
        public int? Year { get; set; }
        public int? Color { get; set; }
        public int? FuelType { get; set; }
        public int? PassengerCapacity { get; set; }
        public int? LoadCapacity { get; set; }
        public string InvoiceNumber { get; set; }
        public string Source { get; set; }
        public DateTime? DateRecieved { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public bool? IsActive { get; set; }
        public int? VehicleClassification { get; set; }

        public virtual AColour ColorNavigation { get; set; }
        public virtual DistFuelType FuelTypeNavigation { get; set; }
        public virtual DistVehicleMake MakeNavigation { get; set; }
        public virtual DistVehicleModel ModelNavigation { get; set; }
        public virtual ICollection<DistIncidentReport> DistIncidentReport { get; set; }
        public virtual ICollection<DistIncidentReportOtherVehicle> DistIncidentReportOtherVehicle { get; set; }
        public virtual ICollection<DistLogbook> DistLogbook { get; set; }
        public virtual ICollection<DistVehicleAuthorization> DistVehicleAuthorization { get; set; }
        public virtual ICollection<DistVehicleCheckDefectReport> DistVehicleCheckDefectReport { get; set; }
        public virtual ICollection<DistVehicleCheckRecommendation> DistVehicleCheckRecommendation { get; set; }
        public virtual ICollection<DistVehicleInventoryTracking> DistVehicleInventoryTracking { get; set; }
        public virtual ICollection<DistVehicleMaintaince> DistVehicleMaintaince { get; set; }
    }
}
