using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class OrderPrepHeaderLog
    {
        public string OrderNumber { get; set; }
        public int FacilityCode { get; set; }
        public int OrderStatusId { get; set; }
        public string OrderStatusChangedBy { get; set; }
        public DateTime OrderStatusDateChanged { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DatePrepared { get; set; }
        public int? OrderTypeId { get; set; }
        public int? ProductCategoryId { get; set; }
    }
}
