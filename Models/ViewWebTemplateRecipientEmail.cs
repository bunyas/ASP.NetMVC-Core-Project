using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewWebTemplateRecipientEmail
    {
        public int? CtTelephone { get; set; }
        public string CeEmail { get; set; }
        public string CpName { get; set; }
        public string TitleDesc { get; set; }
        public int FacilityCode { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public string Facility { get; set; }
        public int CpCode { get; set; }
        public bool? DisableReceived { get; set; }
        public bool? DisableProcessed { get; set; }
        public bool? DisableDispatched { get; set; }
        public bool? DisableDelivered { get; set; }
        public bool? IsActive { get; set; }
        public bool? DisableComfirmed { get; set; }
        public bool? DisableAll { get; set; }
    }
}
