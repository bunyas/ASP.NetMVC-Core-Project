using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewOrderTrackingModule1
    {
        public string Facility { get; set; }
        public string DistrictName { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public string LevelOfCare { get; set; }
        public string OrderNumber { get; set; }
        public string Status { get; set; }
        public string OrderType { get; set; }
        public string CategoryDesc { get; set; }
        public string OrderStatusChangedBy { get; set; }
        public DateTime? OrderStatusDateChanged { get; set; }
        public DateTime? DatePrepared { get; set; }
        public int? ProductCategoryId { get; set; }
        public int FacilityCode { get; set; }
        public int? OrderStatusId { get; set; }
        public int? OrderTypeId { get; set; }
    }
}
