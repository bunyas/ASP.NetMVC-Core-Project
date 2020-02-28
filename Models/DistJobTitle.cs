using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistJobTitle
    {
        public DistJobTitle()
        {
            DistOperatorPersonal = new HashSet<DistOperatorPersonal>();
            DistVehicleInventoryTracking = new HashSet<DistVehicleInventoryTracking>();
        }

        public int JobTitleCode { get; set; }
        public string TitleDesc { get; set; }

        public virtual ICollection<DistOperatorPersonal> DistOperatorPersonal { get; set; }
        public virtual ICollection<DistVehicleInventoryTracking> DistVehicleInventoryTracking { get; set; }
    }
}
