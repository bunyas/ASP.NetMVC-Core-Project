using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AImplimentingPartners
    {
        public AImplimentingPartners()
        {
            ADistrict = new HashSet<ADistrict>();
            AFacilities = new HashSet<AFacilities>();
            FoComplaint = new HashSet<FoComplaint>();
            FoContactPerson = new HashSet<FoContactPerson>();
        }

        public int ImplimentingPartnerCode { get; set; }
        public string ImplementingPartnerDescription { get; set; }

        public virtual ICollection<ADistrict> ADistrict { get; set; }
        public virtual ICollection<AFacilities> AFacilities { get; set; }
        public virtual ICollection<FoComplaint> FoComplaint { get; set; }
        public virtual ICollection<FoContactPerson> FoContactPerson { get; set; }
    }
}
