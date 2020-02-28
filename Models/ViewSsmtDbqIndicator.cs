using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewSsmtDbqIndicator
    {
        public int DistrictCode { get; set; }
        public int FacilityCode { get; set; }
        public string DistrictName { get; set; }
        public string Facility { get; set; }
        public string LevelOfCare { get; set; }
        public DateTime DateVisited { get; set; }
        public string CategoryDesc { get; set; }
        public string IndicatorDesc { get; set; }
        public string IndicatorNotes { get; set; }
        public string SubindicatorDesc { get; set; }
        public int? MoHHmis { get; set; }
        public int? YesNo { get; set; }
        public int? MaxScore { get; set; }
        public int? Score { get; set; }
        public bool? Exist { get; set; }
        public int? StaffTrained { get; set; }
    }
}
