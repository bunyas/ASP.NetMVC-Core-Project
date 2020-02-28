using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoASsmt
    {
        public FoASsmt()
        {
            FoSsmtSiteTracker = new HashSet<FoSsmtSiteTracker>();
        }

        public int SsmtCode { get; set; }
        public string SsmtDesc { get; set; }

        public virtual ICollection<FoSsmtSiteTracker> FoSsmtSiteTracker { get; set; }
    }
}
