using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewCCcuComplaintAvgDays
    {
        public string MMonthYear { get; set; }
        public int? MYear { get; set; }
        public int? MMonth { get; set; }
        public string MonthDesc { get; set; }
        public int? DaysTaken { get; set; }
        public int? Resolved { get; set; }
        public DateTime? ERegDateRecieved { get; set; }
    }
}
