﻿using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisConVlX
    {
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int ProductCode { get; set; }
        public double? Consumption { get; set; }
        public string OrderNumber { get; set; }
    }
}
