using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewFoComplaintCurrent
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
    }
}
