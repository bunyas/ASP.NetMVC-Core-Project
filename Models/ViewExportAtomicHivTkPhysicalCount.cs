using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewExportAtomicHivTkPhysicalCount
    {
        public int FacilityCode { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public string ZoneDescription { get; set; }
        public int? DistrrictCode { get; set; }
        public string DistrictName { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public int? LevelOfCare { get; set; }
        public string LevelDesc { get; set; }
        public string Scto { get; set; }
        public DateTime DateOfPhysicalCount { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int ProductCode { get; set; }
        public string ProductSapCode { get; set; }
        public string ProductDescription { get; set; }
        public string BatchNo { get; set; }
        public double? QuantityDispensary { get; set; }
        public double? QuantityStore { get; set; }
        public double? Total { get; set; }
        public string Comment { get; set; }
        public string AddedBy { get; set; }
        public DateTime DateAdded { get; set; }
        public bool? RecordStatus { get; set; }
    }
}
