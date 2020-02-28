using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewFoComplaintCurrentQualityIssue
    {
        public int ERegComplaintCode { get; set; }
        public DateTime? ERegDateRecieved { get; set; }
        public int? ERegComplaintCategory { get; set; }
        public string ERegComplaintDetails { get; set; }
        public int? ERegAffectedSites { get; set; }
        public int? ERegProductCategory { get; set; }
        public int? ERegCommunicationMode { get; set; }
        public DateTime? ERegDateResolved { get; set; }
        public DateTime? ERegExpectedDateResolution { get; set; }
        public int? ERegContactPersonId { get; set; }
        public int? CpTitle { get; set; }
        public int? CpFacility { get; set; }
        public int? CpDistrict { get; set; }
        public int? CpCategory { get; set; }
        public int? CpIp { get; set; }
        public int? CpSupplierCode { get; set; }
        public DateTime? ERegTrackDateOfAction { get; set; }
        public string ERegTrackActionDetails { get; set; }
        public int? ERegTrackStatus { get; set; }
        public string ERegTrackMaulStaff { get; set; }
        public int? ERegComplaintAccuteness { get; set; }
        public int ERegTrackCode { get; set; }
        public bool? DeletedRecord { get; set; }
        public bool? IsQualityIssue { get; set; }
        public string BatchNo { get; set; }
        public string ComplainantName { get; set; }
        public int? ComplainantPhone { get; set; }
        public int? ComplainantTitle { get; set; }
        public string ComplainantEmail { get; set; }
        public int? ProductCode { get; set; }
        public string ProductStrength { get; set; }
        public string DosageForm { get; set; }
        public string ProductOther { get; set; }
        public string Manufacturer { get; set; }
        public DateTime? DateQualityIssueIdentified { get; set; }
        public string DescriptionOfQualityIssue { get; set; }
        public int? InterventionTaken { get; set; }
        public string InterventionTakenOther { get; set; }
        public string RecipientName { get; set; }
        public int? RecipientTitle { get; set; }
        public bool? AttachedPicture { get; set; }
        public bool? AttachedEmail { get; set; }
        public bool? AttachedNoteLetter { get; set; }
        public byte[] AttachedImagePicture { get; set; }
        public string AttachedImageEmail { get; set; }
        public string AttachedImageLetter { get; set; }
    }
}
