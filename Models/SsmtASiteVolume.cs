using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SsmtASiteVolume
    {
        public SsmtASiteVolume()
        {
            SsmtFacility = new HashSet<SsmtFacility>();
        }

        public int SiteVolumeCode { get; set; }
        public string SiteVolumeDesc { get; set; }

        public virtual ICollection<SsmtFacility> SsmtFacility { get; set; }
    }
}
