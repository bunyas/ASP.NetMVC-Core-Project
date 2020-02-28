using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDashboardPatientsNumbersArtFluconazole
    {
        public int FacilityCode { get; set; }
        public string Facility { get; set; }
        public int AdultsFluconazole { get; set; }
        public int ChildrenFluconazole { get; set; }
        public int? TotalPatientsFluconazole { get; set; }
        public int ConditionCode { get; set; }
        public string Condition { get; set; }
        public string EndMonthName { get; set; }
        public int? EndMonth { get; set; }
        public int? EndYear { get; set; }
    }
}
