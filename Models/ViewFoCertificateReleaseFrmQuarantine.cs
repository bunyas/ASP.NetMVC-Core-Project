using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewFoCertificateReleaseFrmQuarantine
    {
        public int Id { get; set; }
        public int ERegComplaintCode { get; set; }
        public string BatchNo { get; set; }
        public int ProductCode { get; set; }
        public int CpCode { get; set; }
        public string StaffName { get; set; }
        public int? StaffPhone { get; set; }
        public int? StaffDesignation { get; set; }
        public string StaffEmail { get; set; }
        public DateTime? DateRequest { get; set; }
        public string ProductStrength { get; set; }
        public string DosageForm { get; set; }
        public string ProductOther { get; set; }
        public string Manufacturer { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Supplier { get; set; }
        public string ERegComplaintNo { get; set; }
        public string SummaryOfInvestigations { get; set; }
        public int? ReleaseInstruction { get; set; }
        public int? CopyInvestigationReport { get; set; }
        public int? GoodsReturnedNote { get; set; }
        public int? AttachedOtherDoc { get; set; }
        public string AttachedOther { get; set; }
        public int? ReleaseAuthorizedby { get; set; }
        public DateTime? ReleaseAuthorizedDate { get; set; }
        public int? ReleasedBy { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReceivedBy { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public int? AuthorizedRepresentativeCategory { get; set; }
        public string GoodsReturnedNoteCommet { get; set; }
    }
}
