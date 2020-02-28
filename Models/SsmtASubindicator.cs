using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SsmtASubindicator
    {
        public SsmtASubindicator()
        {
            SsmtAIndicatorSubindicator = new HashSet<SsmtAIndicatorSubindicator>();
            SsmtIndicator = new HashSet<SsmtIndicator>();
        }

        public int SubindicatorId { get; set; }
        public string SubindicatorDesc { get; set; }

        public virtual ICollection<SsmtAIndicatorSubindicator> SsmtAIndicatorSubindicator { get; set; }
        public virtual ICollection<SsmtIndicator> SsmtIndicator { get; set; }
    }
}
