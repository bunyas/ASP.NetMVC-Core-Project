﻿using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewSsmtFacilityMostRecentVisitYearMonth
    {
        public int FacilityId { get; set; }
        public int? BYear { get; set; }
        public int? BMonth { get; set; }
        public DateTime? DateVisited { get; set; }
    }
}
