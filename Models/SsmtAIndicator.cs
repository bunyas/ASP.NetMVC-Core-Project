using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SsmtAIndicator
    {
        public SsmtAIndicator()
        {
            SsmtAIndicatorSubindicator = new HashSet<SsmtAIndicatorSubindicator>();
            SsmtIndicator = new HashSet<SsmtIndicator>();
        }

        public int IndicatorId { get; set; }
        public int? CategoryId { get; set; }
        public string IndicatorDesc { get; set; }
        public string IndicatorNotes { get; set; }

        public virtual SsmtACategory Category { get; set; }
        public virtual ICollection<SsmtAIndicatorSubindicator> SsmtAIndicatorSubindicator { get; set; }
        public virtual ICollection<SsmtIndicator> SsmtIndicator { get; set; }
    }
}
