using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssNeedsAssessment5
    {
        public HssNeedsAssessment5()
        {
            HssNeedsAssessmentItInfrastractureDispensaryNavigation = new HashSet<HssNeedsAssessmentItInfrastracture>();
            HssNeedsAssessmentItInfrastractureStoresNavigation = new HashSet<HssNeedsAssessmentItInfrastracture>();
            HssNeedsAssessmentPhysicalInfrastructureRoom1Navigation = new HashSet<HssNeedsAssessmentPhysicalInfrastructure>();
            HssNeedsAssessmentPhysicalInfrastructureRoom2Navigation = new HashSet<HssNeedsAssessmentPhysicalInfrastructure>();
            HssNeedsAssessmentPhysicalInfrastructureRoom3Navigation = new HashSet<HssNeedsAssessmentPhysicalInfrastructure>();
            HssNeedsAssessmentPhysicalInfrastructureRoom4Navigation = new HashSet<HssNeedsAssessmentPhysicalInfrastructure>();
            HssNeedsAssessmentSpaceOptimizationCurrentStorageArvNavigation = new HashSet<HssNeedsAssessmentSpaceOptimization>();
            HssNeedsAssessmentSpaceOptimizationGeneralMedicinesNavigation = new HashSet<HssNeedsAssessmentSpaceOptimization>();
            HssNeedsAssessmentSpaceOptimizationProposedStorageArvNavigation = new HashSet<HssNeedsAssessmentSpaceOptimization>();
            HssNeedsAssessmentSpaceOptimizationRoom4Navigation = new HashSet<HssNeedsAssessmentSpaceOptimization>();
        }

        public string NeedsAssessment5Code { get; set; }
        public string NeedsAssessment5Desc { get; set; }

        public virtual ICollection<HssNeedsAssessmentItInfrastracture> HssNeedsAssessmentItInfrastractureDispensaryNavigation { get; set; }
        public virtual ICollection<HssNeedsAssessmentItInfrastracture> HssNeedsAssessmentItInfrastractureStoresNavigation { get; set; }
        public virtual ICollection<HssNeedsAssessmentPhysicalInfrastructure> HssNeedsAssessmentPhysicalInfrastructureRoom1Navigation { get; set; }
        public virtual ICollection<HssNeedsAssessmentPhysicalInfrastructure> HssNeedsAssessmentPhysicalInfrastructureRoom2Navigation { get; set; }
        public virtual ICollection<HssNeedsAssessmentPhysicalInfrastructure> HssNeedsAssessmentPhysicalInfrastructureRoom3Navigation { get; set; }
        public virtual ICollection<HssNeedsAssessmentPhysicalInfrastructure> HssNeedsAssessmentPhysicalInfrastructureRoom4Navigation { get; set; }
        public virtual ICollection<HssNeedsAssessmentSpaceOptimization> HssNeedsAssessmentSpaceOptimizationCurrentStorageArvNavigation { get; set; }
        public virtual ICollection<HssNeedsAssessmentSpaceOptimization> HssNeedsAssessmentSpaceOptimizationGeneralMedicinesNavigation { get; set; }
        public virtual ICollection<HssNeedsAssessmentSpaceOptimization> HssNeedsAssessmentSpaceOptimizationProposedStorageArvNavigation { get; set; }
        public virtual ICollection<HssNeedsAssessmentSpaceOptimization> HssNeedsAssessmentSpaceOptimizationRoom4Navigation { get; set; }
    }
}
