using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoContactEmail
    {
        public int CpCode { get; set; }
        public string CeEmail { get; set; }
        public string PersonalEmail { get; set; }
        public bool? DisableReceived { get; set; }
        public bool? DisableProcessed { get; set; }
        public bool? DisableDispatched { get; set; }
        public bool? DisableDelivered { get; set; }
        public bool? DisableComfirmed { get; set; }
        public bool? DisableAll { get; set; }

        public virtual FoContactPerson CpCodeNavigation { get; set; }
    }
}
