using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistVehicleCheckStatus
    {
        public DistVehicleCheckStatus()
        {
            DistVehicleCheckDefectReport = new HashSet<DistVehicleCheckDefectReport>();
        }

        public int StatusCode { get; set; }
        public int ParticularCode { get; set; }
        public string StatusDesc { get; set; }

        public virtual DistVehicleCheckParticular ParticularCodeNavigation { get; set; }
        public virtual ICollection<DistVehicleCheckDefectReport> DistVehicleCheckDefectReport { get; set; }
    }
}
