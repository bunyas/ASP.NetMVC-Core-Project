using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDashboardConsumptionFacilityHiv
    {
        public string OrderNumber { get; set; }
        public int ItemCode { get; set; }
        public double? TestUsed2months { get; set; }
        public int FacilityCode { get; set; }
        public string Facility { get; set; }
        public string ProductDescription { get; set; }
        public string EndMonthName { get; set; }
        public int? EndMonth { get; set; }
        public int? EndYear { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
