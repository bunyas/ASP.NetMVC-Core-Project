﻿using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisSummaryRecievedReports
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int FacilityCode { get; set; }
        public DateTime? DatePrepared { get; set; }
        public int? DeliveryZoneCode { get; set; }
    }
}