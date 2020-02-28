using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SsmtRptIndicator
    {
        public int RptIndicatorId { get; set; }
        public int RptCategoryId { get; set; }
        public int FacilityId { get; set; }
        public DateTime DateVisit { get; set; }

        public virtual SsmtARptCategory RptCategory { get; set; }
        public virtual SsmtARptIndicator RptIndicator { get; set; }
        public virtual SsmtFacility SsmtFacility { get; set; }
    }
}
