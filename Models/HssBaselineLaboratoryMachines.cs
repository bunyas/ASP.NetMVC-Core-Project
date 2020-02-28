using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineLaboratoryMachines
    {
        public int FacilityCode { get; set; }
        public DateTime InterviewDate { get; set; }
        public int ItemCode { get; set; }
        public string AvialabilityServiceContract { get; set; }
        public int? ServiceProvider { get; set; }
        public int? ServiceFrequency { get; set; }
        public string Remarks { get; set; }

        public virtual HssBaselineLaboratoryServiceFrequency ServiceFrequencyNavigation { get; set; }
        public virtual HssBaselineLaboratoryServiceProvider ServiceProviderNavigation { get; set; }
    }
}
