using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoComplaintTracker
    {
        public FoComplaintTracker()
        {
            FoComplaintActionTaken = new HashSet<FoComplaintActionTaken>();
        }

        public int ERegTrackCode { get; set; }
        public int ERegTrackComplaintCode { get; set; }
        public DateTime? ERegTrackDateOfAction { get; set; }
        public int? ERegTrackActionCategory { get; set; }
        public string ERegTrackActionDetails { get; set; }
        public int? ERegTrackStatus { get; set; }
        public string ERegTrackMaulStaff { get; set; }
        public bool? ERegTrackRecordStatus { get; set; }
        public string ERegTrackAddedBy { get; set; }
        public DateTime? ERegTrackAddedDate { get; set; }
        public string ERegTrackActionTaken { get; set; }

        public virtual FoAActionTaken ERegTrackActionCategoryNavigation { get; set; }
        public virtual FoComplaint ERegTrackComplaintCodeNavigation { get; set; }
        public virtual FoAStatus ERegTrackStatusNavigation { get; set; }
        public virtual ICollection<FoComplaintActionTaken> FoComplaintActionTaken { get; set; }
    }
}
