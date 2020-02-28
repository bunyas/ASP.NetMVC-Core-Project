using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoComplaintActiontakenTracker
    {
        public int ActionId { get; set; }
        public int? ERegComplaintCode { get; set; }
        public string ERegComplaintNo { get; set; }
        public DateTime? ActionDate { get; set; }
        public string ActionDescription { get; set; }
        public string AddedBy { get; set; }

        public virtual FoComplaint ERegComplaintCodeNavigation { get; set; }
    }
}
