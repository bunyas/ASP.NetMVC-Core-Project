using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssSupervisor
    {
        public int Id { get; set; }
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int SupervisionType { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int? Phone { get; set; }
        public string Title { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual ChssSupervisorType SupervisionTypeNavigation { get; set; }
    }
}
