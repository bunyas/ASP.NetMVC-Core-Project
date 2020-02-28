using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistFuelType
    {
        public DistFuelType()
        {
            DistVehicleInventory = new HashSet<DistVehicleInventory>();
        }

        public int FuelCode { get; set; }
        public string FuelType { get; set; }

        public virtual ICollection<DistVehicleInventory> DistVehicleInventory { get; set; }
    }
}
