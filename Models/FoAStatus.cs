using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoAStatus
    {
        public FoAStatus()
        {
            FoComplaint = new HashSet<FoComplaint>();
            FoComplaintTracker = new HashSet<FoComplaintTracker>();
        }

        public int StatusCode { get; set; }
        public string StatusDesc { get; set; }

        public virtual ICollection<FoComplaint> FoComplaint { get; set; }
        public virtual ICollection<FoComplaintTracker> FoComplaintTracker { get; set; }
    }
}
