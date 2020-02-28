using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisFrostLabA
    {
        public string LevelOfCare { get; set; }
        public string DistrictName { get; set; }
        public int FacilityCode { get; set; }
        public string Facility { get; set; }
        public string ProductDescription { get; set; }
        public int? DistrictCode { get; set; }
        public double? Soh { get; set; }
        public double? Amc { get; set; }
        public DateTime? AmcDate { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int ItemCode { get; set; }
        public double? Consumption { get; set; }
        public double? ClosingBalance { get; set; }
        public int? QuantityAllocated { get; set; }
    }
}
