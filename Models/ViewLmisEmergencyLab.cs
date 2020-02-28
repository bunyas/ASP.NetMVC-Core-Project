using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisEmergencyLab
    {
        public int ProductOrder { get; set; }
        public int? ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string BasicUnit { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string OpeningBalance { get; set; }
        public string QuantityRecieved { get; set; }
        public string Consumption { get; set; }
        public string LossesAdjustment { get; set; }
        public string ClosingBalance { get; set; }
        public string QuantityToOrder { get; set; }
        public string QuantityAllocated { get; set; }
        public string TotalCost { get; set; }
        public string Comments { get; set; }
        public string Rfsonotes { get; set; }
        public bool? IsVisible { get; set; }
        public DateTime? DatePrepared { get; set; }
        public bool? FinalSubmission { get; set; }
        public bool? FinalSubmissionCheck { get; set; }
        public bool? RfsoSentBackTofacility { get; set; }
        public string RfsoSentBackBy { get; set; }
        public DateTime? RfsoSentBackDate { get; set; }
        public string RfsoApprovedBy { get; set; }
        public DateTime? RfsoDateOfApproval { get; set; }
        public bool? RfsoApproveOrder { get; set; }
        public bool? EportedToSap { get; set; }
        public DateTime? FacilityUpdateDate { get; set; }
        public string FacilityUserName { get; set; }
    }
}
