using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistVehicleCheckRecommendation
    {
        public DistVehicleCheckRecommendation()
        {
            DistVehicleCheckDefectReport = new HashSet<DistVehicleCheckDefectReport>();
        }

        public DateTime DateOfAssessment { get; set; }
        public string VehicleRegistration { get; set; }
        public string OperatorPermit { get; set; }
        public bool? IsVehicleFitForTrip { get; set; }
        public string AdditionalRemarks { get; set; }
        public string AssessingOfficer { get; set; }
        public int? VehicleType { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }

        public virtual DistOperatorPersonal OperatorPermitNavigation { get; set; }
        public virtual DistVehicleInventory VehicleRegistrationNavigation { get; set; }
        public virtual ICollection<DistVehicleCheckDefectReport> DistVehicleCheckDefectReport { get; set; }
    }
}
