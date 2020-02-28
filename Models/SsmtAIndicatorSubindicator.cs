using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SsmtAIndicatorSubindicator
    {
        public int IndicatorId { get; set; }
        public int SubindicatorId { get; set; }

        public virtual SsmtAIndicator Indicator { get; set; }
        public virtual SsmtASubindicator Subindicator { get; set; }
    }
}
