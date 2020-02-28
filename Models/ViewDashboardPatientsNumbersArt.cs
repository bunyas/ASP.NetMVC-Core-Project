using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDashboardPatientsNumbersArt
    {
        public int FacilityCode { get; set; }
        public string Facility { get; set; }
        public int? AdultsPatients { get; set; }
        public int? ChildPatients { get; set; }
        public string EndMonthName { get; set; }
        public int? EndMonth { get; set; }
        public int? EndYear { get; set; }
    }
}
