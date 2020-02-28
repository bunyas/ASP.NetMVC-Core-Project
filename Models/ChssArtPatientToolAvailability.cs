using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssArtPatientToolAvailability
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int GuidId { get; set; }
        public bool? Availability { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual ChssQuestionGuid Guid { get; set; }
    }
}
