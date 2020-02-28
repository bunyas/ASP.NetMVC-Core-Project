using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisEmergencyTestKit
    {
        public int ProductOrder { get; set; }
        public int? ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string BasicUnit { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string NoTestStart2months { get; set; }
        public string TestRecieved2months { get; set; }
        public string TestUsed2months { get; set; }
        public string LossAdjustment { get; set; }
        public string TestRemaining { get; set; }
        public string MaximumStock { get; set; }
        public string QunatityOnOrder { get; set; }
        public string QuantityRequired { get; set; }
        public string QuantityToShip { get; set; }
        public string Rfsonotes { get; set; }
        public string QuantityAllocated { get; set; }
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
