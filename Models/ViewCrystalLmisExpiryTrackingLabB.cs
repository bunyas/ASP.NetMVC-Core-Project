using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewCrystalLmisExpiryTrackingLabB
    {
        public int FacilityCode { get; set; }
        public DateTime? DateOfPhysicalCount { get; set; }
        public string BatchNo { get; set; }
        public double? QuantityDispensary { get; set; }
        public double? QuantityStore { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double? Total { get; set; }
        public int ProductCode { get; set; }
        public bool? RecordStatus { get; set; }
    }
}
