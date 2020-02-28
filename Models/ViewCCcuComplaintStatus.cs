using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewCCcuComplaintStatus
    {
        public string MYearMonth { get; set; }
        public int? MYear { get; set; }
        public int? MMonth { get; set; }
        public string MonthDesc { get; set; }
        public string Classification { get; set; }
        public int? ComplaintNo { get; set; }
        public DateTime? ERegDateRecieved { get; set; }
    }
}
