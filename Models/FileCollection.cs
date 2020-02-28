using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FileCollection
    {
        public string Id { get; set; }
        public string FileUrl { get; set; }
        public string FileType { get; set; }
        public string Details { get; set; }
        public int? ERegComplaintCode { get; set; }
        public string ERegComplaintNo { get; set; }

        public virtual FoComplaint ERegComplaintCodeNavigation { get; set; }
    }
}
