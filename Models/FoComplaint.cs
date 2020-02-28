using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoComplaint
    {
        public FoComplaint()
        {
            FileCollection = new HashSet<FileCollection>();
            FoComplaintActiontakenTracker = new HashSet<FoComplaintActiontakenTracker>();
            FoComplaintAffectedSites = new HashSet<FoComplaintAffectedSites>();
            FoComplaintInvestigation = new HashSet<FoComplaintInvestigation>();
            FoComplaintTracker = new HashSet<FoComplaintTracker>();
            FoEmailsSent = new HashSet<FoEmailsSent>();
            FoQiCloseOutCertificate = new HashSet<FoQiCloseOutCertificate>();
        }

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
        public bool? Level1EmailSent { get; set; }
        public bool? Level2EmailSent { get; set; }
        public string Level1Assignment { get; set; }
        public DateTime? Level1AssignmentDate { get; set; }
        public string Level2Assignment { get; set; }
        public DateTime? Level2AssignmentDate { get; set; }

        public virtual FoContactCategory ComplainantCategoryNavigation { get; set; }
        public virtual AFacilities ComplainantFacilityCodeNavigation { get; set; }
        public virtual FoACommunicationMode ERegCommunicationModeNavigation { get; set; }
        public virtual FoAComplaintAccuteness ERegComplaintAccutenessNavigation { get; set; }
        public virtual FoAComplaintCategory ERegComplaintCategoryNavigation { get; set; }
        public virtual FoAStatus ERegComplaintStatusNavigation { get; set; }
        public virtual AYesNo FinalSubmissionNavigation { get; set; }
        public virtual AImplimentingPartners IpNavigation { get; set; }
        public virtual ICollection<FileCollection> FileCollection { get; set; }
        public virtual ICollection<FoComplaintActiontakenTracker> FoComplaintActiontakenTracker { get; set; }
        public virtual ICollection<FoComplaintAffectedSites> FoComplaintAffectedSites { get; set; }
        public virtual ICollection<FoComplaintInvestigation> FoComplaintInvestigation { get; set; }
        public virtual ICollection<FoComplaintTracker> FoComplaintTracker { get; set; }
        public virtual ICollection<FoEmailsSent> FoEmailsSent { get; set; }
        public virtual ICollection<FoQiCloseOutCertificate> FoQiCloseOutCertificate { get; set; }
    }
}
