﻿using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewCCcuComplaintAccuteness
    {
        public string MYearMonth { get; set; }
        public int? MYear { get; set; }
        public int? MMonth { get; set; }
        public int? ERegComplaintAccuteness { get; set; }
        public string MonthDesc { get; set; }
        public int? ComplaintNo { get; set; }
        public string AccutenessDesc { get; set; }
        public DateTime? ERegDateRecieved { get; set; }
    }
}
