using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewCrystalLmisAllcationSmc
    {
        public string SapCode { get; set; }
        public string Packsize { get; set; }
        public string ProductDescription { get; set; }
        public int ProductCode { get; set; }
        public string DistrictName { get; set; }
        public string Facility { get; set; }
        public int? AllocationMonth { get; set; }
        public int? AllocationYear { get; set; }
        public int? QuantityAllocated { get; set; }
        public bool? RecordStatus { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public int? DistrrictCode { get; set; }
    }
}
