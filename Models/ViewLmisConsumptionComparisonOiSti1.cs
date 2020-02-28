using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisConsumptionComparisonOiSti1
    {
        public DateTime? EndDate { get; set; }
        public int DrugCode { get; set; }
        public string ProductDescription { get; set; }
        public int? FacilityCode { get; set; }
        public string Facility { get; set; }
        public double? Consumption { get; set; }
        public int? DeliveryZoneCode { get; set; }
    }
}
