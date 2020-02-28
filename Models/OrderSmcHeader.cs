using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class OrderSmcHeader
    {
        public OrderSmcHeader()
        {
            OrderSmc = new HashSet<OrderSmc>();
        }

        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? DatePrepared { get; set; }
        public int? TargetNumber { get; set; }
        public int? ActualNumber { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public bool? IsApproved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool? RecordStatus { get; set; }
        public bool? EmergencyOrder { get; set; }

        public virtual UsersUserInformation AddedByNavigation { get; set; }
        public virtual UsersUserInformation EditedByNavigation { get; set; }
        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual SapSmcSiteOrderHeader SapSmcSiteOrderHeader { get; set; }
        public virtual ICollection<OrderSmc> OrderSmc { get; set; }
    }
}
