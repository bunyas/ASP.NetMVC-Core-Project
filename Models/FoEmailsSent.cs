using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoEmailsSent
    {
        public int EmailId { get; set; }
        public int? ERegComplaintCode { get; set; }
        public string ERegComplaintNo { get; set; }
        public DateTime? SentDate { get; set; }
        public bool? LevelOne { get; set; }
        public bool? LevelTwo { get; set; }
        public bool? LevelThree { get; set; }

        public virtual FoComplaint ERegComplaintCodeNavigation { get; set; }
    }
}
