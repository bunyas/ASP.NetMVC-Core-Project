using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineLaboratoryServiceFrequency
    {
        public HssBaselineLaboratoryServiceFrequency()
        {
            HssBaselineLaboratoryMachines = new HashSet<HssBaselineLaboratoryMachines>();
        }

        public int ServiceFrequencyCode { get; set; }
        public string ServiceFrequencyDesc { get; set; }

        public virtual ICollection<HssBaselineLaboratoryMachines> HssBaselineLaboratoryMachines { get; set; }
    }
}
