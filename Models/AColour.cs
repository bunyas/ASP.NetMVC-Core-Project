using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AColour
    {
        public AColour()
        {
            DistVehicleInventory = new HashSet<DistVehicleInventory>();
        }

        public int ColourCode { get; set; }
        public string Colour { get; set; }

        public virtual ICollection<DistVehicleInventory> DistVehicleInventory { get; set; }
    }
}
