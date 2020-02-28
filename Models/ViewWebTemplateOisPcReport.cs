using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewWebTemplateOisPcReport
    {
        public int ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Strength { get; set; }
        public string Packsize { get; set; }
        public int? CartonSizePkt { get; set; }
        public double? CartonWeightKg { get; set; }
        public int? ProductCategory { get; set; }
        public short? BasicUnit { get; set; }
        public int? ArtProductClassification { get; set; }
        public string SapCode { get; set; }
        public DateTime DateOfPhysicalCount { get; set; }
        public string BatchNo { get; set; }
        public double? QuantityDispensary { get; set; }
        public double? QuantityStore { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double? Total { get; set; }
        public string Comment { get; set; }
        public int FacilityCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime DateAdded { get; set; }
        public int? MonthsToExpire { get; set; }
        public bool? RecordStatus { get; set; }
    }
}
