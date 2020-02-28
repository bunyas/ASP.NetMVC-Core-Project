using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class WebTemplateSummaryGuides
    {
        public WebTemplateSummaryGuides()
        {
            OrderRutfHeaderSummary = new HashSet<OrderRutfHeaderSummary>();
            OrderSmcSlmSummary = new HashSet<OrderSmcSlmSummary>();
            OrderTbSummary = new HashSet<OrderTbSummary>();
            OrderViralLoadReagentsSummary = new HashSet<OrderViralLoadReagentsSummary>();
        }

        public int Id { get; set; }
        public string SummaryCategory { get; set; }
        public string SummaryDescription { get; set; }

        public virtual ICollection<OrderRutfHeaderSummary> OrderRutfHeaderSummary { get; set; }
        public virtual ICollection<OrderSmcSlmSummary> OrderSmcSlmSummary { get; set; }
        public virtual ICollection<OrderTbSummary> OrderTbSummary { get; set; }
        public virtual ICollection<OrderViralLoadReagentsSummary> OrderViralLoadReagentsSummary { get; set; }
    }
}
