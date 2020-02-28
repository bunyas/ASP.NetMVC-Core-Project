using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisExpectedReportsY
    {
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? Lab { get; set; }
        public int? Arv { get; set; }
        public int? HivTestKits { get; set; }
        public int? OiSti { get; set; }
        public int? SmcSlm { get; set; }
        public int? ViralLoadReagents { get; set; }
    }
}
