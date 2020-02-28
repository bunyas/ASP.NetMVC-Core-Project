using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDashboardFacilityTrackingOrderStautus
    {
        public string Facility { get; set; }
        public string OrderNumber { get; set; }
        public string OrderType { get; set; }
        public string CategoryDesc { get; set; }
        public DateTime? StartDate { get; set; }
        public int? ProductCategoryId { get; set; }
        public int FacilityCode { get; set; }
        public int? OrderStatusId { get; set; }
        public string OrderStatus { get; set; }
        public int? OrderTypeId { get; set; }
        public string EndMonthName { get; set; }
        public int? EndMonth { get; set; }
        public int? EndYear { get; set; }
    }
}
