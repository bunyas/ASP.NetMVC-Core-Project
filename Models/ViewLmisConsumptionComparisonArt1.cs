using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisConsumptionComparisonArt1
    {
        public double Consumption { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? EndDate { get; set; }
        public string Facility { get; set; }
        public int DrugCode { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public string ProductDescription { get; set; }
    }
}
