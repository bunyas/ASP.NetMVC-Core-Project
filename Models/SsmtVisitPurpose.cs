using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SsmtVisitPurpose
    {
        public int FacilityId { get; set; }
        public DateTime DateVisit { get; set; }
        public int VisitPurposeCode { get; set; }
        public bool? Visited { get; set; }
        public string Comment { get; set; }

        public virtual SsmtFacility SsmtFacility { get; set; }
        public virtual SsmtAVisitPurpose VisitPurposeCodeNavigation { get; set; }
    }
}
