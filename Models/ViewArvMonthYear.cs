using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewArvMonthYear
    {
        public int? XYear { get; set; }
        public int? XMonth { get; set; }
        public string MonthDesc { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public int? LevelOfCareCode { get; set; }
        public string LevelOfCare { get; set; }
    }
}
