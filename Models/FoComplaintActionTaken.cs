using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoComplaintActionTaken
    {
        public int ERegTrackCode { get; set; }
        public int ActionCode { get; set; }

        public virtual FoAActionTaken ActionCodeNavigation { get; set; }
        public virtual FoComplaintTracker ERegTrackCodeNavigation { get; set; }
    }
}
