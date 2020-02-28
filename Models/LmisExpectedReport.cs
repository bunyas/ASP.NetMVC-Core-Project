using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class LmisExpectedReport
    {
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ProductCategory { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual AProductCategory ProductCategoryNavigation { get; set; }
    }
}
