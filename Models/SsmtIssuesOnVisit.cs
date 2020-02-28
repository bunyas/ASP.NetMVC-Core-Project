using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SsmtIssuesOnVisit
    {
        public int FacilityId { get; set; }
        public DateTime DateVisit { get; set; }
        public int IssueCode { get; set; }
        public string FindingCurrentVisit { get; set; }
        public string RecommendationCurrentVisit { get; set; }
        public string PlanOfAction { get; set; }
        public DateTime? TimelineStart { get; set; }
        public DateTime? TimelineEnd { get; set; }
        public int? ResponsiblePerson { get; set; }
        public string FollowUpFutureVisit { get; set; }
        public DateTime? DateOfFollowUp { get; set; }
    }
}
