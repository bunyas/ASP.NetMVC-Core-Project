using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistIncidentReportOtherVehicle
    {
        public string OperatorPermit { get; set; }
        public DateTime DateOfIncident { get; set; }
        public string VehicleRegistartion { get; set; }
        public string OtherVehicleReg { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPermit { get; set; }
        public string OperatorName { get; set; }
        public int? InsuranceCompany { get; set; }
        public string OwnerContactName { get; set; }
        public int? OwnerContactTel { get; set; }

        public virtual DistIncidentReport DistIncidentReport { get; set; }
        public virtual DistVehicleInventory VehicleRegistartionNavigation { get; set; }
    }
}
