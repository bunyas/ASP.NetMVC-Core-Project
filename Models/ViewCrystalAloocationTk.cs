using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewCrystalAloocationTk
    {
        public string SapCode { get; set; }
        public string Packsize { get; set; }
        public string ProductDescription { get; set; }
        public int ProductCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? QuantityAllocated { get; set; }
        public string DistrictName { get; set; }
        public string Facility { get; set; }
        public int? AllocationYear { get; set; }
        public int? AllocationMonth { get; set; }
    }
}
