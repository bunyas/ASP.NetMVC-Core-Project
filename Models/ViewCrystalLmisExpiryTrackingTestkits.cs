using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewCrystalLmisExpiryTrackingTestkits
    {
        public int? ImplimentingPartnerCode { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public int? LevelOfCareCode { get; set; }
        public string LevelOfCare { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public string Facility { get; set; }
        public string SapCode { get; set; }
        public string ProductDescription { get; set; }
        public string Packsize { get; set; }
        public DateTime? DateOfPhysicalCount { get; set; }
        public string BatchNo { get; set; }
        public double? QuantityDispensary { get; set; }
        public double? QuantityStore { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double? Quantity { get; set; }
    }
}
