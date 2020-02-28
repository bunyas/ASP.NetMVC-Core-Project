using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewSsmtDispAidTools
    {
        public int IndicatorId { get; set; }
        public int SubindicatorId { get; set; }
        public string IndicatorDesc { get; set; }
        public string IndicatorNotes { get; set; }
        public string SubindicatorDesc { get; set; }
        public string YesNo { get; set; }
        public string MoHHmis { get; set; }
        public string MaxScore { get; set; }
        public string Score { get; set; }
    }
}
