using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewExportAtomicLab
    {
        public int FacilityCode { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public string DistrictName { get; set; }
        public string ZoneDescription { get; set; }
        public string Cdcregion { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public string LevelOfCare { get; set; }
        public string FacilityType { get; set; }
        public string Scto { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DateCompleted { get; set; }
        public DateTime? DateExpected { get; set; }
        public bool? EmergencyOrder { get; set; }
        public bool? FinalSubmission { get; set; }
        public string OrderType { get; set; }
        public string Status { get; set; }
        public int StatusId { get; set; }
        public int? ProductCode { get; set; }
        public string ProductSapCode { get; set; }
        public string ProductDescription { get; set; }
        public string LabCat1Desc { get; set; }
        public string LabCat2Desc { get; set; }
        public string Strength { get; set; }
        public string Packsize { get; set; }
        public double? OpeningBalance { get; set; }
        public double? QuantityRecieved { get; set; }
        public double? Consumption { get; set; }
        public double? LossesAdjustment { get; set; }
        public double? ClosingBalance { get; set; }
        public double? QuantityToOrder { get; set; }
        public double? QuantityAllocated { get; set; }
        public double? TotalCost { get; set; }
        public string Comments { get; set; }
        public string Rfsonotes { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public string OrderStatusIdChangedBy { get; set; }
        public DateTime? OrderStatusIdDateChanged { get; set; }
    }
}
