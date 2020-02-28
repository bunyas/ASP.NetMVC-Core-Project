using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SsmtACategory
    {
        public SsmtACategory()
        {
            SsmtAIndicator = new HashSet<SsmtAIndicator>();
            SsmtComment = new HashSet<SsmtComment>();
            SsmtFacilitySummaryScore = new HashSet<SsmtFacilitySummaryScore>();
        }

        public int CategoryId { get; set; }
        public string CategoryDesc { get; set; }

        public virtual ICollection<SsmtAIndicator> SsmtAIndicator { get; set; }
        public virtual ICollection<SsmtComment> SsmtComment { get; set; }
        public virtual ICollection<SsmtFacilitySummaryScore> SsmtFacilitySummaryScore { get; set; }
    }
}
