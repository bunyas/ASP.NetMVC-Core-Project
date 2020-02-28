using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewOrderLabCustomOrders
    {
        public string OrderNumber { get; set; }
        public int FacilityCode { get; set; }
        public bool? EmergencyOrder { get; set; }
        public bool? FinalSubmission { get; set; }
        public int? OrderTypeId { get; set; }
        public int? OrderStatusId { get; set; }
        public string OrderStatusIdChangedBy { get; set; }
        public DateTime? OrderStatusIdDateChanged { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public DateTime? DateExpected { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public int? DistrrictCode { get; set; }
        public string FacilityTypeId { get; set; }
        public DateTime? DatePrepared { get; set; }
        public int? ProductCategoryId { get; set; }
        public bool? RfsoSentBackTofacility { get; set; }
    }
}
