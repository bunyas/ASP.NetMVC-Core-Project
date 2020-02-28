using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewOrderDrugDetails
    {
        public double? QuantityRequiredCurrentPatients { get; set; }
        public double? QuantityAllocated { get; set; }
        public string Notes { get; set; }
        public string Rfsonotes { get; set; }
        public int DrugCode { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string OrderNumber { get; set; }
        public bool? FinalSubmission { get; set; }
        public int? OrderTypeId { get; set; }
        public int? OrderStatusId { get; set; }
        public string OrderStatusIdChangedBy { get; set; }
        public DateTime? OrderStatusIdDateChanged { get; set; }
        public string EditedBy { get; set; }
        public double? OpeningBalance { get; set; }
        public double? QuantityRecieved { get; set; }
        public double? PmtctConsumption { get; set; }
        public double? ArtConsumption { get; set; }
        public double? LossesAdjustments { get; set; }
        public double? ClosingBalance { get; set; }
        public double? MonthsStockAtHand { get; set; }
        public double? EstimatedNewArtPatients { get; set; }
        public double? EstimatedNewHivPregnant { get; set; }
        public double? DrugsRequiredNewPatients { get; set; }
        public double? TotalDrugsRequired { get; set; }
        public double? DaysOutOfStockDuring2Months { get; set; }
        public double? AdjustedAmc { get; set; }
        public double? ArtEMtctConsumption { get; set; }
        public bool? EmergencyOrder { get; set; }
        public int? Children { get; set; }
        public int? Adults { get; set; }
        public DateTime? DatePrepared { get; set; }
        public DateTime? EditedDate { get; set; }
        public DateTime? DateExpected { get; set; }
        public string FacilityUserName { get; set; }
        public bool? RfsoSentBackTofacility { get; set; }
        public string RfsoSentBackBy { get; set; }
        public DateTime? RfsoSentBackDate { get; set; }
        public bool? RfsoApproveOrder { get; set; }
        public DateTime? RfsoDateOfApproval { get; set; }
        public string RfsoApprovedBy { get; set; }
    }
}
