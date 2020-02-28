using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewFoComplaintAffectedSites
    {
        public int ERegComplaintCode { get; set; }
        public string ERegComplaintNo { get; set; }
        public int? ERegContactPersonId { get; set; }
        public DateTime? ERegDateRecieved { get; set; }
        public DateTime? ERegDateComplaint { get; set; }
        public int? ERegComplaintCategory { get; set; }
        public string ERegComplaintTitle { get; set; }
        public string ERegComplaintDetails { get; set; }
        public int? ERegMaulStaff { get; set; }
        public int? ERegComplaintStatus { get; set; }
        public int? ERegAffectedSites { get; set; }
        public int? ERegProductCategory { get; set; }
        public int? ERegCommunicationMode { get; set; }
        public DateTime? ERegDateResolved { get; set; }
        public DateTime? ERegExpectedDateResolution { get; set; }
        public int? ERegComplaintAccuteness { get; set; }
        public bool? DeletedRecord { get; set; }
        public bool? IsQualityIssue { get; set; }
        public string AffectedSites { get; set; }
        public string FacilityCode { get; set; }
        public bool? SupDocEvidenceRec { get; set; }
        public bool? ProdSamplesProvided { get; set; }
        public string CommunicatedByLev1 { get; set; }
        public string CommunicatedByLev1Title { get; set; }
        public DateTime? CommunicatedByLev1Date { get; set; }
        public bool? EmailLetterAttached { get; set; }
        public int? CommunicatedByLev2 { get; set; }
        public string CommunicatedByLev2Title { get; set; }
        public DateTime? CommunicatedByLev2Date { get; set; }
        public bool? CommunicatedByLev2Email { get; set; }
        public string Feedback { get; set; }
        public int? FeedbackCommunicated { get; set; }
        public DateTime? FeedbackDate { get; set; }
        public string BriefFeedbackDesc { get; set; }
        public string NoFeedbackReason { get; set; }
        public string ComplainantName { get; set; }
        public string ComplainantTitle { get; set; }
        public string ComplainantEmail { get; set; }
        public string ComplainantMobile { get; set; }
        public string ComplainantPhone { get; set; }
        public int? ComplainantFacilityCode { get; set; }
        public int? ComplainantDistrict { get; set; }
        public int? Ip { get; set; }
        public int? FinalSubmission { get; set; }
        public int? ComplainantCategory { get; set; }
    }
}
