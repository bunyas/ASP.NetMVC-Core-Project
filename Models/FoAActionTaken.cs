using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoAActionTaken
    {
        public FoAActionTaken()
        {
            FoComplaintActionTaken = new HashSet<FoComplaintActionTaken>();
            FoComplaintQualityIssue = new HashSet<FoComplaintQualityIssue>();
            FoComplaintTracker = new HashSet<FoComplaintTracker>();
        }

        public int ActionTakenCode { get; set; }
        public string ActionTakenDesc { get; set; }

        public virtual ICollection<FoComplaintActionTaken> FoComplaintActionTaken { get; set; }
        public virtual ICollection<FoComplaintQualityIssue> FoComplaintQualityIssue { get; set; }
        public virtual ICollection<FoComplaintTracker> FoComplaintTracker { get; set; }
    }
}
