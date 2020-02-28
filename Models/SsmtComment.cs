using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SsmtComment
    {
        public int FacilityId { get; set; }
        public DateTime DateVisit { get; set; }
        public int CategoryId { get; set; }
        public string Notes { get; set; }

        public virtual SsmtACategory Category { get; set; }
        public virtual SsmtFacility SsmtFacility { get; set; }
    }
}
