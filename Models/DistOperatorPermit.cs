using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistOperatorPermit
    {
        public DistOperatorPermit()
        {
            DistDistibutionSchedule = new HashSet<DistDistibutionSchedule>();
            DistIncidentReport = new HashSet<DistIncidentReport>();
            DistLogbook = new HashSet<DistLogbook>();
            DistVehicleMaintaince = new HashSet<DistVehicleMaintaince>();
        }

        public string DriverPermitNumber { get; set; }
        public string OperatorId { get; set; }
        public int? PermitCategory { get; set; }
        public DateTime? PermitDateOfIssue { get; set; }
        public DateTime? PermitExpiryDate { get; set; }
        public bool? ValidPermit { get; set; }

        public virtual DistPermitCategory PermitCategoryNavigation { get; set; }
        public virtual ICollection<DistDistibutionSchedule> DistDistibutionSchedule { get; set; }
        public virtual ICollection<DistIncidentReport> DistIncidentReport { get; set; }
        public virtual ICollection<DistLogbook> DistLogbook { get; set; }
        public virtual ICollection<DistVehicleMaintaince> DistVehicleMaintaince { get; set; }
    }
}
