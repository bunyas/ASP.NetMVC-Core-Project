using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoSsmtSiteTracker
    {
        public FoSsmtSiteTracker()
        {
            FoSsmtSiteTrackerSubmittedDocument = new HashSet<FoSsmtSiteTrackerSubmittedDocument>();
        }

        public DateTime DateOfVisit { get; set; }
        public int FacilityCode { get; set; }
        public int? Rfso { get; set; }
        public int? ArtReadiness { get; set; }
        public int? PatientNo { get; set; }
        public int? VisitPurpose { get; set; }
        public string VisitPurposePrimary { get; set; }
        public int? Ssmt { get; set; }

        public virtual FoASsmt SsmtNavigation { get; set; }
        public virtual FoSsmtVisitPurpose VisitPurposeNavigation { get; set; }
        public virtual ICollection<FoSsmtSiteTrackerSubmittedDocument> FoSsmtSiteTrackerSubmittedDocument { get; set; }
    }
}
