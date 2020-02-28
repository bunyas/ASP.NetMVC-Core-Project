using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewSsmtDbqRptIndicator
    {
        public int DistrictCode { get; set; }
        public int FacilityCode { get; set; }
        public string DistrictName { get; set; }
        public string Facility { get; set; }
        public string LevelOfCare { get; set; }
        public DateTime DateVisit { get; set; }
        public string RptIndicatorDesc { get; set; }
        public string RptCategoryDesc { get; set; }
    }
}
