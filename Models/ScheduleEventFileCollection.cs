using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ScheduleEventFileCollection
    {
        public string Id { get; set; }
        public string FileUrl { get; set; }
        public string FileType { get; set; }
        public string Details { get; set; }
        public string SheduleAppId { get; set; }

        public virtual ScheduleEvent SheduleApp { get; set; }
    }
}
