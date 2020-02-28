using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoSsmtInterviewedPersonnel
    {
        public int PersonnelCode { get; set; }
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string Name { get; set; }
        public int? Gender { get; set; }
        public int? Position { get; set; }
        public int? TelephoneNumber { get; set; }
        public string Email { get; set; }

        public virtual FoSsmtFacility FoSsmtFacility { get; set; }
        public virtual AGender GenderNavigation { get; set; }
        public virtual FoContactTitle PositionNavigation { get; set; }
    }
}
