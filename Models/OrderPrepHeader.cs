using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class OrderPrepHeader
    {
        public OrderPrepHeader()
        {
            OrderPrepdetails = new HashSet<OrderPrepdetails>();
        }

        public string OrderNumber { get; set; }
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? DatePrepared { get; set; }
        public int? Adults { get; set; }
        public int? Children { get; set; }
        public bool? EmergencyOrder { get; set; }
        public bool? FinalSubmission { get; set; }
        public int? OrderTypeId { get; set; }
        public int? OrderStatusId { get; set; }
        public string OrderStatusIdChangedBy { get; set; }
        public DateTime? OrderStatusIdDateChanged { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public DateTime? DateExpected { get; set; }
        public string FacilityUserName { get; set; }
        public bool? RfsoSentBackTofacility { get; set; }
        public string RfsoSentBackBy { get; set; }
        public DateTime? RfsoSentBackDate { get; set; }
        public bool? RfsoApproveOrder { get; set; }
        public string RfsoApprovedBy { get; set; }
        public DateTime? RfsoDateOfApproval { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual AOrderStatus OrderStatus { get; set; }
        public virtual AOrderType OrderType { get; set; }
        public virtual ICollection<OrderPrepdetails> OrderPrepdetails { get; set; }
    }
}
