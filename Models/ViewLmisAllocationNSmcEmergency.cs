﻿using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisAllocationNSmcEmergency
    {
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DatePrepared { get; set; }
        public int ProductCode { get; set; }
        public string Description { get; set; }
        public string UoM { get; set; }
        public double? OpeningBalance { get; set; }
        public double? QtyRecieved { get; set; }
        public double? Consumption { get; set; }
        public double? LossesAndAdjustments { get; set; }
        public double? TotalClosingBalance { get; set; }
        public int? QuantityAllocated { get; set; }
        public double? QuantityToOrder { get; set; }
        public string Comments { get; set; }
        public string Rfsonotes { get; set; }
    }
}
