using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class OrderHivRapidTestKitPhysicalCount
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfPhysicalCount { get; set; }
        public int ProductCode { get; set; }
        public string BatchNo { get; set; }
        public double? QuantityDispensary { get; set; }
        public double? QuantityStore { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double? Total { get; set; }
        public string Comment { get; set; }
        public string AddedBy { get; set; }
        public DateTime DateAdded { get; set; }
        public bool? RecordStatus { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual AProduct ProductCodeNavigation { get; set; }
    }
}
