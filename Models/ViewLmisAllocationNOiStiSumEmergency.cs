﻿using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisAllocationNOiStiSumEmergency
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ProductCode { get; set; }
        public double? QuantityAllocated { get; set; }
    }
}
