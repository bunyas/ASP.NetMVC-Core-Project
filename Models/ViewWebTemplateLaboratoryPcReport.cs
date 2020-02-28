using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewWebTemplateLaboratoryPcReport
    {
        public string LabCat1Desc { get; set; }
        public string LabCat2Desc { get; set; }
        public string ProductDescription { get; set; }
        public string Strength { get; set; }
        public string Packsize { get; set; }
        public int? CartonSizePkt { get; set; }
        public double? CartonWeightKg { get; set; }
        public short? BasicUnit { get; set; }
        public int FacilityCode { get; set; }
        public DateTime DateOfPhysicalCount { get; set; }
        public string BatchNo { get; set; }
        public double? QuantityDispensary { get; set; }
        public double? QuantityStore { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double? Total { get; set; }
        public string Comment { get; set; }
        public string LabCat3Desc { get; set; }
        public string AddedBy { get; set; }
        public DateTime DateAdded { get; set; }
        public bool? RecordStatus { get; set; }
        public int? MonthsToExpire { get; set; }
    }
}
