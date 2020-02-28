using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewWebTemplateRutfSummary
    {
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public string SummaryCategory { get; set; }
        public string SummaryDescription { get; set; }
        public string OrderNumber { get; set; }
        public int Id { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ExpectedNew { get; set; }
        public int? Old { get; set; }
    }
}
