using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisSummarySites
    {
        public int FacilityCode { get; set; }
        public int? DistrrictCode { get; set; }
        public bool? IsAccredited { get; set; }
        public bool? SupportedByMaul { get; set; }
        public string DistrictName { get; set; }
        public int DistrictCode { get; set; }
    }
}
