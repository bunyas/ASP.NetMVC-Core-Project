using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewPatientSummary
    {
        public int FacilityCode { get; set; }
        public int? BYear { get; set; }
        public int? BMonth { get; set; }
        public short? RegimenCategoryCode { get; set; }
        public short RegimenCode { get; set; }
        public string Category { get; set; }
        public int? PatientsNew { get; set; }
        public int? PatientsExisting { get; set; }
        public int? PatientsTotal { get; set; }
    }
}
