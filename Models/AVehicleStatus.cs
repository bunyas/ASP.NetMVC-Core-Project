using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AVehicleStatus
    {
        public AVehicleStatus()
        {
            AVehicle = new HashSet<AVehicle>();
        }

        public int VehicleStatusCode { get; set; }
        public string VehicleStatusDesc { get; set; }

        public virtual ICollection<AVehicle> AVehicle { get; set; }
    }
}
