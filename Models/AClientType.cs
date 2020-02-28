using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AClientType
    {
        public AClientType()
        {
            AFacilities = new HashSet<AFacilities>();
        }

        public int ClientTypeCode { get; set; }
        public string ClientTypeDesc { get; set; }

        public virtual ICollection<AFacilities> AFacilities { get; set; }
    }
}
