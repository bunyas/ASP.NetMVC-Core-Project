using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SsmtPersonnel
    {
        public int SsmtPersonnelId { get; set; }
        public int? FacilityId { get; set; }
        public DateTime? DateVisit { get; set; }
        public int? PersonnelId { get; set; }
        public string PersonnelName { get; set; }
        public int? GenderId { get; set; }
        public int? TitleId { get; set; }
        public int? LocationId { get; set; }
        public int? Telephone { get; set; }
        public string Email { get; set; }

        public virtual SsmtALocation Location { get; set; }
        public virtual SsmtAPersonnel Personnel { get; set; }
        public virtual SsmtFacility SsmtFacility { get; set; }
    }
}
