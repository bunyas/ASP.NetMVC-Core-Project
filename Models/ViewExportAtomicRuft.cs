using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewExportAtomicRuft
    {
        public string Facility { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public string ZoneDescription { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public int? DistrrictCode { get; set; }
        public string District { get; set; }
        public string SapCode { get; set; }
        public int FacilityCode { get; set; }
        public bool? SupportedByMaul { get; set; }
        public bool? IsAccredited { get; set; }
        public int? LevelOfCare { get; set; }
        public string LevelDesc { get; set; }
        public int? ClientTypeCode { get; set; }
        public string ClientTypeDesc { get; set; }
        public int? OwnershipId { get; set; }
        public string OwnershipDescription { get; set; }
        public int? CdcregionId { get; set; }
        public string Cdcregion { get; set; }
        public string FacilityTypeId { get; set; }
        public string FacilityType { get; set; }
        public int? ComprehensiveImplimentingPartnerCode { get; set; }
        public string ComprehensiveImplementingPartnerDescription { get; set; }
        public int? PatientLoadCode { get; set; }
        public string PatientLoadDescription { get; set; }
        public string Scto { get; set; }
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
        public string OrderType { get; set; }
        public string OrderStatus { get; set; }
        public string OrderNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? DatePrepared { get; set; }
        public bool? EmergencyOrder { get; set; }
        public bool? FinalSubmission { get; set; }
        public bool? ExportedToSap { get; set; }
        public int? OrderTypeId { get; set; }
        public int? OrderStatusId { get; set; }
        public string OrderStatusIdChangedBy { get; set; }
        public DateTime? OrderStatusIdDateChanged { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public DateTime? DateExpected { get; set; }
        public string FacilityUserName { get; set; }
        public bool? RfsoSentBackTofacility { get; set; }
        public string RfsoSentBackBy { get; set; }
        public DateTime? RfsoSentBackDate { get; set; }
        public bool? RfsoApproveOrder { get; set; }
        public string RfsoApprovedBy { get; set; }
        public DateTime? RfsoDateOfApproval { get; set; }
        public int ProductCode1 { get; set; }
        public double? OpeningBalance { get; set; }
        public double? QuantityReceived { get; set; }
        public double? Consumption { get; set; }
        public double? LossesAdjustments { get; set; }
        public double? ClosingBalance { get; set; }
        public double? QuantityRequired { get; set; }
        public string Notes { get; set; }
        public double? QuantityAllocated { get; set; }
        public string Rfsonotes { get; set; }
    }
}
