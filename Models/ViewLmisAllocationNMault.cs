using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisAllocationNMault
    {
        public string OrderNumber { get; set; }
        public int FacilityCode { get; set; }
        public DateTime? DateExpected { get; set; }
        public bool? EmergencyOrder { get; set; }
        public int? ProductCategoryId { get; set; }
        public int? OrderStatusId { get; set; }
        public int ProductCode { get; set; }
        public double? QuantityRequired { get; set; }
        public double? QuantityAllocated { get; set; }
        public string Rfsonotes { get; set; }
        public string Notes { get; set; }
        public DateTime? DatePrepared { get; set; }
    }
}
