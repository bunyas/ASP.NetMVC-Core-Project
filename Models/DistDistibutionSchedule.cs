using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistDistibutionSchedule
    {
        public DistDistibutionSchedule()
        {
            DistDistibutionScheduleMaulStaff = new HashSet<DistDistibutionScheduleMaulStaff>();
        }

        public int FacilityCode { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime? ExpectedDateAtSite { get; set; }
        public int? StatusId { get; set; }
        public DateTime? ActualDateAtSite { get; set; }
        public int? StatusDeliveyId { get; set; }
        public string VehicleRegistration { get; set; }
        public string DriverPermitNumber { get; set; }
        public string Remark { get; set; }
        public double? TotalWeightCartons { get; set; }
        public double? TotalNoCartons { get; set; }

        public virtual DistOperatorPermit DriverPermitNumberNavigation { get; set; }
        public virtual ICollection<DistDistibutionScheduleMaulStaff> DistDistibutionScheduleMaulStaff { get; set; }
    }
}
