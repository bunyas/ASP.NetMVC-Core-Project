﻿using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisAllocationNLabSumEmergency
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? QuantityAllocated { get; set; }
        public int ItemCode { get; set; }
    }
}
