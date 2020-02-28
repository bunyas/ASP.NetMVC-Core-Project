using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssDnGrnHeader
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string AddedBy { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}
