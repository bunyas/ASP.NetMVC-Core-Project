using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewWebTemplateArv
    {
        public int ProductOrder { get; set; }
        public int? ProductCode { get; set; }
        public string ProductNumbering { get; set; }
        public string ProductDescription { get; set; }
        public string BasicUnit { get; set; }
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
        public string Notes { get; set; }
        public string Rfsonotes { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
