using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewFoContactsDetails
    {
        public int CpCode { get; set; }
        public string CpName { get; set; }
        public int? CpTitle { get; set; }
        public int? CpFacility { get; set; }
        public int? CpDistrict { get; set; }
        public int? CpCategory { get; set; }
        public int? CpIp { get; set; }
        public int? CpSupplierCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public int? CtTelephon { get; set; }
        public int? CtTelephone2 { get; set; }
        public string CeEmail { get; set; }
        public bool? DisableReceived { get; set; }
        public bool? DisableComfirmed { get; set; }
        public bool? DisableProcessed { get; set; }
        public bool? DisableDispatched { get; set; }
        public bool? DisableDelivered { get; set; }
        public bool? DisableAll { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public int? FacilityId { get; set; }
        public string UserName { get; set; }
        public int AccessFailedCount { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public string Id { get; set; }
        public string Role { get; set; }
        public bool? IsActive { get; set; }
    }
}
