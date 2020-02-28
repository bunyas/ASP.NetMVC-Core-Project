using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AVehicleType
    {
        public AVehicleType()
        {
            AVehicle = new HashSet<AVehicle>();
        }

        public int AVehicleTypeCode { get; set; }
        public string AVehicleTypeDesc { get; set; }

        public virtual ICollection<AVehicle> AVehicle { get; set; }
    }
}
