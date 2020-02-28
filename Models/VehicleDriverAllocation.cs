using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class VehicleDriverAllocation
    {
        public VehicleDriverAllocation()
        {
            MileageForm = new HashSet<MileageForm>();
            VehiclePackingListAllocation = new HashSet<VehiclePackingListAllocation>();
        }

        public int DriverVehicleCode { get; set; }
        public string VehicleNumber { get; set; }
        public string DriverPermit { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? DeliveryZone { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }

        public virtual UserAccount AddedByNavigation { get; set; }
        public virtual ADeliveryZone DeliveryZoneNavigation { get; set; }
        public virtual ADriver DriverPermitNavigation { get; set; }
        public virtual UserAccount EditedByNavigation { get; set; }
        public virtual AVehicle VehicleNumberNavigation { get; set; }
        public virtual ICollection<MileageForm> MileageForm { get; set; }
        public virtual ICollection<VehiclePackingListAllocation> VehiclePackingListAllocation { get; set; }
    }
}
