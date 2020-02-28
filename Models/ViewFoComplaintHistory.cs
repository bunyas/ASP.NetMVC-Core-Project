using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewFoComplaintHistory
    {
        public int ERegTrackComplaintCode { get; set; }
        public int ERegTrackCode { get; set; }
        public DateTime? ERegTrackDateOfAction { get; set; }
        public int? ERegTrackActionCategory { get; set; }
        public string ERegTrackActionDetails { get; set; }
        public string ERegTrackMaulStaff { get; set; }
        public int? ERegTrackStatus { get; set; }
        public string ERegTrackAddedBy { get; set; }
        public DateTime? ERegTrackAddedDate { get; set; }
    }
}
