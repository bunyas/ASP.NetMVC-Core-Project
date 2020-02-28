using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssNeedsAssessment
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int HssNeedsAssessment2Code { get; set; }
        public int HssNeedsAssessment3Code { get; set; }
        public int? YesNo { get; set; }
        public double? Number { get; set; }
        public double? ProposedArvStore { get; set; }
        public double? GeneralMedicines { get; set; }
        public double? CurrentArvStore { get; set; }
        public int? Dispensary { get; set; }
        public int? Stores { get; set; }
        public int? Room1 { get; set; }
        public int? Room2 { get; set; }
        public int? Room3 { get; set; }
        public int? Room4 { get; set; }
        public string Comments { get; set; }

        public virtual HssNeedsAssessment2 HssNeedsAssessment2CodeNavigation { get; set; }
        public virtual HssNeedsAssessment3 HssNeedsAssessment3CodeNavigation { get; set; }
    }
}
