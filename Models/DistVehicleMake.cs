using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistVehicleMake
    {
        public DistVehicleMake()
        {
            DistVehicleInventory = new HashSet<DistVehicleInventory>();
        }

        public int MakeCode { get; set; }
        public string MakeDesc { get; set; }

        public virtual ICollection<DistVehicleInventory> DistVehicleInventory { get; set; }
    }
}
