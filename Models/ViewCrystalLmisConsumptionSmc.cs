using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewCrystalLmisConsumptionSmc
    {
        public int? DeliveryZoneCode { get; set; }
        public string Facility { get; set; }
        public string SapCode { get; set; }
        public string AllocationMonth { get; set; }
        public string AllocationYear { get; set; }
        public double? Consumption { get; set; }
        public double? ClosingBalance { get; set; }
        public double? StockLevel { get; set; }
        public string DistrictName { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Packsize { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int FacilityCode { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public int? DistrrictCode { get; set; }
        public bool? RecordStatus { get; set; }
        public int ProductCode1 { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public string Strength { get; set; }
        public int? CartonSizePkt { get; set; }
    }
}
