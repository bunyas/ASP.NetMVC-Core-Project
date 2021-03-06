﻿using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisAllocationNOiSti
    {
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? DatePrepared { get; set; }
        public int ProductCode { get; set; }
        public double? PhysicalCountAtBeginningOfReviewPeriod { get; set; }
        public double? QuantityReceivedDuringTheTwoMonthsCycle { get; set; }
        public double? QuantityUsedDuringTwoMonths { get; set; }
        public double? LossesAndAdjustments { get; set; }
        public double? NumberOfDaysOutOfStock { get; set; }
        public double? ThisMonthPhysicalCount { get; set; }
        public double? Amc { get; set; }
        public double? MonthsOfStock { get; set; }
        public double? MaximumStockQuantity { get; set; }
        public double? QuantityRequired { get; set; }
        public string Notes { get; set; }
        public double? QuantityAllocated { get; set; }
        public string Rfsonotes { get; set; }
        public string OrderNumber { get; set; }
        public int? OrderTypeId { get; set; }
        public int? OrderStatusId { get; set; }
        public bool? EmergencyOrder { get; set; }
        public string Facility { get; set; }
    }
}
