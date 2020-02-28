using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ACounty
    {
        public ACounty()
        {
            ASubcounty = new HashSet<ASubcounty>();
        }

        public string CountyId { get; set; }
        public int? DistrictId { get; set; }
        public string CountyName { get; set; }
        public string CountyMinistryCode { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual ICollection<ASubcounty> ASubcounty { get; set; }
    }
}
