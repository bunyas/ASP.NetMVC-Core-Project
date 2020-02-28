using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewOrderLabCustom
    {
        public string OrderNumber { get; set; }
        public int FacilityCode { get; set; }
        public DateTime? DatePrepared { get; set; }
        public DateTime? DateExpected { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public bool? EmergencyOrder { get; set; }
        public bool? FinalSubmission { get; set; }
        public int? ProductCategoryId { get; set; }
        public int? OrderStatusId { get; set; }
        public string OrderStatusIdChangedBy { get; set; }
        public DateTime? OrderStatusIdDateChanged { get; set; }
        public int ProductCode { get; set; }
        public double? QuantityRequired { get; set; }
        public double? QuantityAllocated { get; set; }
        public string Rfsonotes { get; set; }
        public string Notes { get; set; }
        public string FacilityUserName { get; set; }
        public bool? RfsoSentBackTofacility { get; set; }
        public string RfsoSentBackBy { get; set; }
        public bool? RfsoApproveOrder { get; set; }
        public DateTime? RfsoSentBackDate { get; set; }
        public string RfsoApprovedBy { get; set; }
        public DateTime? RfsoDateOfApproval { get; set; }
        public int? OrderTypeId { get; set; }
    }
}
