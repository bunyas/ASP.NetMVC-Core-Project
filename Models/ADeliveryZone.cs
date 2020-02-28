using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ADeliveryZone
    {
        public ADeliveryZone()
        {
            AFacilities = new HashSet<AFacilities>();
            VehicleDriverAllocation = new HashSet<VehicleDriverAllocation>();
        }

        public int ZoneCode { get; set; }
        public string ZoneDescription { get; set; }

        public virtual ICollection<AFacilities> AFacilities { get; set; }
        public virtual ICollection<VehicleDriverAllocation> VehicleDriverAllocation { get; set; }
    }
}
