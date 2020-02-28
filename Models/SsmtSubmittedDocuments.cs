using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SsmtSubmittedDocuments
    {
        public int FacilityId { get; set; }
        public DateTime DateVisit { get; set; }
        public int SubmittedDocCode { get; set; }
        public bool? DocumentSubmitted { get; set; }
        public string Comment { get; set; }

        public virtual SsmtFacility SsmtFacility { get; set; }
        public virtual SsmtASubmittedDoc SubmittedDocCodeNavigation { get; set; }
    }
}
