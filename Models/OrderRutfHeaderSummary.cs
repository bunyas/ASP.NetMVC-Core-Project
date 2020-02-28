using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class OrderRutfHeaderSummary
    {
        public string OrderNumber { get; set; }
        public int Id { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Old { get; set; }
        public int? ExpectedNew { get; set; }

        public virtual WebTemplateSummaryGuides IdNavigation { get; set; }
        public virtual OrderRutfHeader OrderNumberNavigation { get; set; }
    }
}
