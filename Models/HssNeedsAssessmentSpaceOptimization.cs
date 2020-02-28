using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssNeedsAssessmentSpaceOptimization
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int HssNeedsAssessment2Code { get; set; }
        public int HssNeedsAssessment3Code { get; set; }
        public string ProposedStorageArv { get; set; }
        public string GeneralMedicines { get; set; }
        public string CurrentStorageArv { get; set; }
        public string Room4 { get; set; }
        public string Comment { get; set; }

        public virtual HssNeedsAssessment5 CurrentStorageArvNavigation { get; set; }
        public virtual HssNeedsAssessment5 GeneralMedicinesNavigation { get; set; }
        public virtual HssNeedsAssessment2 HssNeedsAssessment2CodeNavigation { get; set; }
        public virtual HssNeedsAssessment3 HssNeedsAssessment3CodeNavigation { get; set; }
        public virtual HssNeedsAssessmentMaster HssNeedsAssessmentMaster { get; set; }
        public virtual HssNeedsAssessment5 ProposedStorageArvNavigation { get; set; }
        public virtual HssNeedsAssessment5 Room4Navigation { get; set; }
    }
}
