using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewWebTemplateSmcSlmEmergency
    {
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DatePrepared { get; set; }
        public int ProductCode { get; set; }
        public string Description { get; set; }
        public string UoM { get; set; }
        public double? OpeningBalance { get; set; }
        public double? QtyRecieved { get; set; }
        public double? Consumption { get; set; }
        public double? LossesAndAdjustments { get; set; }
        public double? TotalClosingBalance { get; set; }
        public int? QuantityAllocated { get; set; }
        public double? QuantityToOrder { get; set; }
        public string Comments { get; set; }
        public string Rfsonotes { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public string FacilityUserName { get; set; }
        public DateTime? FacilityUpdateDate { get; set; }
        public bool? RfsoSentBackTofacility { get; set; }
        public string RfsoSentBackBy { get; set; }
        public DateTime? RfsoSentBackDate { get; set; }
        public string RfsoApprovedBy { get; set; }
        public DateTime? RfsoDateOfApproval { get; set; }
        public bool? RfsoApproveOrder { get; set; }
        public bool? EportedToSap { get; set; }
        public string Rfsonotes1 { get; set; }
        public bool? FinalSubmission { get; set; }
        public int ItemNumber { get; set; }
    }
}
