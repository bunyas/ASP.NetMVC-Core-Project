using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoClientFeedback
    {
        public int Id { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? FeedbackDate { get; set; }
        public int? ContactPersonCode { get; set; }
        public int? ContactPersonDesg { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonDesignation { get; set; }
        public string ContactPersonTele { get; set; }
        public int? SctoVisited { get; set; }
        public string SctosVisited { get; set; }
        public DateTime? SctoLastVist { get; set; }
        public int? MaulServices { get; set; }
        public int? AnyAreasOfConcern { get; set; }
        public string AreasOfConcern { get; set; }
        public string BetterService { get; set; }

        public virtual AYesNo AnyAreasOfConcernNavigation { get; set; }
        public virtual FoContactTitle ContactPersonDesgNavigation { get; set; }
        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual AYesNo MaulServices1 { get; set; }
        public virtual FoAMaulService MaulServicesNavigation { get; set; }
        public virtual AYesNo SctoVisitedNavigation { get; set; }
    }
}
