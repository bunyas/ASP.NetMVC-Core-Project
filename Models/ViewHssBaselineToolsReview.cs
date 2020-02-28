using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewHssBaselineToolsReview
    {
        public int ToolsReview1Code { get; set; }
        public int ToolsReview2Code { get; set; }
        public string ToolsReview1Desc { get; set; }
        public string ToolsReview2Desc { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? InterviewDate { get; set; }
        public string Avialable { get; set; }
        public string Displayed { get; set; }
    }
}
