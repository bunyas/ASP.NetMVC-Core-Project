using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoComplaintQualityIssue
    {
        public FoComplaintQualityIssue()
        {
            FileCollectionSupDoc = new HashSet<FileCollectionSupDoc>();
        }

        public int Id { get; set; }
        public int ERegComplaintCode { get; set; }
        public string ERegComplaintNo { get; set; }
        public string BatchNo { get; set; }
        public int ProductCode { get; set; }
        public string ComplainantName { get; set; }
        public int? ComplainantPhone { get; set; }
        public int? ComplainantTitle { get; set; }
        public string ComplainantEmail { get; set; }
        public string ProductStrength { get; set; }
        public string DosageForm { get; set; }
        public string ProductOther { get; set; }
        public string Manufacturer { get; set; }
        public DateTime? DateQualityIssueIdentified { get; set; }
        public string DescriptionOfQualityIssue { get; set; }
        public int? InterventionTaken { get; set; }
        public string InterventionTakenOther { get; set; }
        public bool? AttachedPicture { get; set; }
        public bool? AttachedEmail { get; set; }
        public bool? AttachedNoteLetter { get; set; }
        public bool? SampleProvided { get; set; }
        public bool? AttachedOtherDoc { get; set; }
        public string AttachedOther { get; set; }
        public string RecipientName { get; set; }
        public int? RecipientTitle { get; set; }
        public byte[] AttachedImagePicture { get; set; }
        public string AttachedImageEmail { get; set; }
        public string AttachedImageLetter { get; set; }
        public double? Quantity { get; set; }
        public string Supplier { get; set; }
        public DateTime? ERegTrackDateOfAction { get; set; }
        public int? ERegTrackActionCategory { get; set; }
        public string ERegTrackActionDetails { get; set; }
        public int? ERegTrackStatus { get; set; }
        public string ERegTrackMaulStaff { get; set; }
        public bool? ProductQuarantined { get; set; }
        public bool? QualityIssuedClosed { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string ERegTrackActionTaken { get; set; }
        public int? ERegFacilityActionTaken { get; set; }

        public virtual FoAActionTaken ERegFacilityActionTakenNavigation { get; set; }
        public virtual ICollection<FileCollectionSupDoc> FileCollectionSupDoc { get; set; }
    }
}
