using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewHssBaselineHfServices
    {
        public int HfService1Code { get; set; }
        public int HfService2Code { get; set; }
        public string HfService2Desc { get; set; }
        public string HfService1Desc { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? InterviewDate { get; set; }
        public string HfServiceValue { get; set; }
        public DateTime? HfServiceDateTime { get; set; }
        public string HfServiceRemarks { get; set; }
    }
}
