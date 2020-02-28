using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewHssBaselineLmis
    {
        public int IndicatorCode { get; set; }
        public string IndicatorDesc { get; set; }
        public int SubIndicatorCode { get; set; }
        public string SubIndicatorDesc { get; set; }
        public string MethodDesc { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? InterviewDate { get; set; }
        public string YesNo { get; set; }
        public string Remarks { get; set; }
    }
}
