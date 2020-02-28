using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisAllocationNArv
    {
        public DateTime? DatePrepared { get; set; }
        public int DrugCode { get; set; }
        public double? OpeningBalance { get; set; }
        public double? QuantityRecieved { get; set; }
        public double? PmtctConsumption { get; set; }
        public double? ArtConsumption { get; set; }
        public double? LossesAdjustments { get; set; }
        public double? ClosingBalance { get; set; }
        public double? MonthsStockAtHand { get; set; }
        public double? QuantityRequiredCurrentPatients { get; set; }
        public double? EstimatedNewArtPatients { get; set; }
        public double? EstimatedNewHivPregnant { get; set; }
        public double? DrugsRequiredNewPatients { get; set; }
        public double? TotalDrugsRequired { get; set; }
        public double? QuantityAllocated { get; set; }
        public string Notes { get; set; }
        public string Rfsonotes { get; set; }
        public double? DaysOutOfStockDuring2Months { get; set; }
        public double? AdjustedAmc { get; set; }
        public double? ArtEMtctConsumption { get; set; }
        public string OrderNumber { get; set; }
        public int? OrderTypeId { get; set; }
        public int? OrderStatusId { get; set; }
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool? EmergencyOrder { get; set; }
        public string Facility { get; set; }
    }
}
