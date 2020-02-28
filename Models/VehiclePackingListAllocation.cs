using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class VehiclePackingListAllocation
    {
        public int FacilityCode { get; set; }
        public DateTime StartDateOrderForm { get; set; }
        public DateTime EndDateOrderForm { get; set; }
        public int DriverVehicleCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }

        public virtual UserAccount AddedByNavigation { get; set; }
        public virtual ApprovedFacilityOrders ApprovedFacilityOrders { get; set; }
        public virtual VehicleDriverAllocation DriverVehicleCodeNavigation { get; set; }
        public virtual UserAccount EditedByNavigation { get; set; }
    }
}
