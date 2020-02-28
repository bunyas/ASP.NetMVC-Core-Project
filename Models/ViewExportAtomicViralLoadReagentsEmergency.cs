using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewExportAtomicViralLoadReagentsEmergency
    {
        public int? DeliveryZoneCode { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public int? DistrrictCode { get; set; }
        public string SapCode { get; set; }
        public int FacilityCode { get; set; }
        public bool? SupportedByMaul { get; set; }
        public bool? IsAccredited { get; set; }
        public int? LevelOfCare { get; set; }
        public int ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Strength { get; set; }
        public string Packsize { get; set; }
        public int? CartonSizePkt { get; set; }
        public double? CartonWeightKg { get; set; }
        public short? BasicUnit { get; set; }
        public bool? ApprovedMohNtg { get; set; }
        public bool? ApprovedWho { get; set; }
        public bool? ApprovedFda { get; set; }
        public int? NdaRegistration { get; set; }
        public string ProductSapCode { get; set; }
        public string Facility { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DatePrepared { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public bool? RecordStatus { get; set; }
        public bool? FinalSubmission { get; set; }
        public string FacilityUserName { get; set; }
        public bool? RfsoSentBackTofacility { get; set; }
        public string RfsoSentBackBy { get; set; }
        public DateTime? RfsoSentBackDate { get; set; }
        public bool? RfsoApproveOrder { get; set; }
        public string RfsoApprovedBy { get; set; }
        public DateTime? RfsoDateOfApproval { get; set; }
        public double? OpeningBalance { get; set; }
        public double? QuantityRecieved { get; set; }
        public double? Consumption { get; set; }
        public double? LossesAndAdjustments { get; set; }
        public double? TotalClosingBalance { get; set; }
        public double? QuantityOrdered { get; set; }
        public string Comment { get; set; }
        public double? QuantityAllocated { get; set; }
        public string Rfsonotes { get; set; }
    }
}
