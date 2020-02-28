using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewCrystalLmisAllocationSmc
    {
        public int? DeliveryZoneCode { get; set; }
        public DateTime StartDate { get; set; }
        public string AllocationMonth { get; set; }
        public string AllocationYear { get; set; }
        public DateTime EndDate { get; set; }
        public double? QuantityToOrder { get; set; }
        public int? QuantityAllocated { get; set; }
        public double? OrderFulfillment { get; set; }
        public int? ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Packsize { get; set; }
        public string DistrictName { get; set; }
        public string Facility { get; set; }
        public string SapCode { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public int? DistrrictCode { get; set; }
        public bool? RecordStatus { get; set; }
        public int FacilityCode { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public string Strength { get; set; }
        public int? CartonSizePkt { get; set; }
    }
}
