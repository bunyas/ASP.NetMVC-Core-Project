using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssVSupervisor
    {
        public int FacilityCode { get; set; }
        public string Facility { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int? Phone { get; set; }
        public string Title { get; set; }
    }
}
