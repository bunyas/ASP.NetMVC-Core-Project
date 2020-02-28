using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewSsmtStVisitsInMonth
    {
        public int FacilityId { get; set; }
        public int? XMonth { get; set; }
        public int? XYear { get; set; }
        public int? VisitsInMonth { get; set; }
    }
}
