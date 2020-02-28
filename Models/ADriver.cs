using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ADriver
    {
        public ADriver()
        {
            VehicleDriverAllocation = new HashSet<VehicleDriverAllocation>();
        }

        public string DriverPermitNumber { get; set; }
        public string DriverName { get; set; }
        public int? DriverStatus { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }

        public virtual UserAccount AddedByNavigation { get; set; }
        public virtual ADriverStatus DriverStatusNavigation { get; set; }
        public virtual UserAccount EditedByNavigation { get; set; }
        public virtual ICollection<VehicleDriverAllocation> VehicleDriverAllocation { get; set; }
    }
}
