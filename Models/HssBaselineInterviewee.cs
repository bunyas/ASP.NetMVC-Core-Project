using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineInterviewee
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string IntervieweeName { get; set; }
        public int Baseline2Code { get; set; }
        public int? IntervieweePosition { get; set; }
        public string IntervieweePhone { get; set; }
        public string IntervieweeEmail { get; set; }
        public bool? RecordStatus { get; set; }
    }
}
