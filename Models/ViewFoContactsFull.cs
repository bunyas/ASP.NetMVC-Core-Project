using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewFoContactsFull
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
        public string PersonalEmail { get; set; }
        public string UserId { get; set; }
        public bool? IsActive { get; set; }
        public string Facility { get; set; }
        public string CategoryDesc { get; set; }
        public string TitleDesc { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public string DistrictName { get; set; }
        public bool? DisableReceived { get; set; }
        public bool? DisableComfirmed { get; set; }
        public bool? DisableProcessed { get; set; }
        public bool? DisableDispatched { get; set; }
        public bool? DisableDelivered { get; set; }
        public bool? DisableAll { get; set; }
    }
}
