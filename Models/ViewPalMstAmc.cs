using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewPalMstAmc
    {
        public string FacilityCode { get; set; }
        public int ProductCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double? AmcValue { get; set; }
    }
}
