using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AVehicle
    {
        public AVehicle()
        {
            VehicleDriverAllocation = new HashSet<VehicleDriverAllocation>();
        }

        public string VehicleNumber { get; set; }
        public int? VehicleCapacityInTonnes { get; set; }
        public int? VehicleType { get; set; }
        public int? VehicleStatus { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }

        public virtual UserAccount AddedByNavigation { get; set; }
        public virtual UserAccount EditedByNavigation { get; set; }
        public virtual AVehicleStatus VehicleStatusNavigation { get; set; }
        public virtual AVehicleType VehicleTypeNavigation { get; set; }
        public virtual ICollection<VehicleDriverAllocation> VehicleDriverAllocation { get; set; }
    }
}
