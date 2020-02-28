using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDashboardTrackingOrderStautus
    {
        public int? NoFacilitits { get; set; }
        public int? EndYear { get; set; }
        public string EndMonthName { get; set; }
        public int? EndMonth { get; set; }
        public string OrderStatus { get; set; }
        public string CategoryDesc { get; set; }
        public int? ProductCategoryId { get; set; }
        public string OrderType { get; set; }
    }
}
