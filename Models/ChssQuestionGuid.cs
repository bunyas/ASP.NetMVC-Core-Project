using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssQuestionGuid
    {
        public ChssQuestionGuid()
        {
            ChssArtPatientToolAvailability = new HashSet<ChssArtPatientToolAvailability>();
            ChssClassification = new HashSet<ChssClassification>();
            ChssExpiryFefoUse = new HashSet<ChssExpiryFefoUse>();
            ChssExpiryPresence = new HashSet<ChssExpiryPresence>();
            ChssExpiryTrackingTools = new HashSet<ChssExpiryTrackingTools>();
            ChssFeedBackPharmacovigilenceSolution = new HashSet<ChssFeedBackPharmacovigilenceSolution>();
            ChssOrderMeans = new HashSet<ChssOrderMeans>();
            ChssStorageCondition = new HashSet<ChssStorageCondition>();
            ChssStoragePractice = new HashSet<ChssStoragePractice>();
            ChssStorageSystem = new HashSet<ChssStorageSystem>();
            ChssStoreCleanliness = new HashSet<ChssStoreCleanliness>();
            ChssTraceabilityRequisitioningSystem = new HashSet<ChssTraceabilityRequisitioningSystem>();
        }

        public int GuidId { get; set; }
        public int ModuleId { get; set; }
        public int SectorId { get; set; }
        public string Question { get; set; }

        public virtual ChssModule Module { get; set; }
        public virtual ChssModuleSector Sector { get; set; }
        public virtual ICollection<ChssArtPatientToolAvailability> ChssArtPatientToolAvailability { get; set; }
        public virtual ICollection<ChssClassification> ChssClassification { get; set; }
        public virtual ICollection<ChssExpiryFefoUse> ChssExpiryFefoUse { get; set; }
        public virtual ICollection<ChssExpiryPresence> ChssExpiryPresence { get; set; }
        public virtual ICollection<ChssExpiryTrackingTools> ChssExpiryTrackingTools { get; set; }
        public virtual ICollection<ChssFeedBackPharmacovigilenceSolution> ChssFeedBackPharmacovigilenceSolution { get; set; }
        public virtual ICollection<ChssOrderMeans> ChssOrderMeans { get; set; }
        public virtual ICollection<ChssStorageCondition> ChssStorageCondition { get; set; }
        public virtual ICollection<ChssStoragePractice> ChssStoragePractice { get; set; }
        public virtual ICollection<ChssStorageSystem> ChssStorageSystem { get; set; }
        public virtual ICollection<ChssStoreCleanliness> ChssStoreCleanliness { get; set; }
        public virtual ICollection<ChssTraceabilityRequisitioningSystem> ChssTraceabilityRequisitioningSystem { get; set; }
    }
}
