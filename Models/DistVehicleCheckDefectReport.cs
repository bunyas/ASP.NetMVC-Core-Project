using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistVehicleCheckDefectReport
    {
        public DateTime DateOfAssessment { get; set; }
        public string VehicleRegistration { get; set; }
        public string OperatorPermit { get; set; }
        public int StatusCode { get; set; }
        public bool? Result { get; set; }
        public string Remark { get; set; }

        public virtual DistVehicleCheckRecommendation DistVehicleCheckRecommendation { get; set; }
        public virtual DistOperatorPersonal OperatorPermitNavigation { get; set; }
        public virtual DistVehicleCheckStatus StatusCodeNavigation { get; set; }
        public virtual DistVehicleInventory VehicleRegistrationNavigation { get; set; }
    }
}
