using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewOrderLabSapExportDetails
    {
        public string OrderNumber { get; set; }
        public int FacilityCode { get; set; }
        public DateTime? DatePrepared { get; set; }
        public int? OrderTypeId { get; set; }
        public int? OrderStatusId { get; set; }
        public int ProductCode { get; set; }
        public double? QuantityRequired { get; set; }
        public double? QuantityAllocated { get; set; }
    }
}
