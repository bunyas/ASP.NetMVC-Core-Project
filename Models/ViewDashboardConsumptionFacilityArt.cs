using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDashboardConsumptionFacilityArt
    {
        public int DrugCode { get; set; }
        public double? ArtEMtctConsumption { get; set; }
        public int FacilityCode { get; set; }
        public string Facility { get; set; }
        public string ProductDescription { get; set; }
        public string EndMonthName { get; set; }
        public int? EndMonth { get; set; }
        public int? EndYear { get; set; }
    }
}
