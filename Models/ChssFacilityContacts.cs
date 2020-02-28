using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssFacilityContacts
    {
        public int FacilityCode { get; set; }
        public string FacilityInchargeName { get; set; }
        public string FacilityInchargeContact { get; set; }
        public string ArtInchargeName { get; set; }
        public string ArtInchargeContact { get; set; }
        public string PharmaconvigilenceName { get; set; }
        public string PharmaconvigilenceContact { get; set; }
        public string MmsName { get; set; }
        public string MmsContact { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
    }
}
