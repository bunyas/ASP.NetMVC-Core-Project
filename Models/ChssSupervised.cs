using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssSupervised
    {
        public int Id { get; set; }
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Profession { get; set; }
        public int? Phone { get; set; }
        public bool? IsTrained { get; set; }
    }
}
