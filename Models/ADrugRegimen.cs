using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ADrugRegimen
    {
        public ADrugRegimen()
        {
            ChssArtPatientTreatementGuide = new HashSet<ChssArtPatientTreatementGuide>();
            ChssOrderPatientsReport = new HashSet<ChssOrderPatientsReport>();
            SsmtVerificationPatientData = new HashSet<SsmtVerificationPatientData>();
            TreatmentPatientSummary = new HashSet<TreatmentPatientSummary>();
        }

        public short RegimenCode { get; set; }
        public string RegimenDesc { get; set; }
        public string ExtraInfo { get; set; }
        public string DrugCombination { get; set; }
        public short? RegimenCategoryCode { get; set; }
        public int? RegimenClassification { get; set; }
        public bool? StandardRegimen { get; set; }
        public bool? IsExtra { get; set; }

        public virtual ADrugRegimenCategory RegimenCategoryCodeNavigation { get; set; }
        public virtual ADrugRegimenClassification RegimenClassificationNavigation { get; set; }
        public virtual ICollection<ChssArtPatientTreatementGuide> ChssArtPatientTreatementGuide { get; set; }
        public virtual ICollection<ChssOrderPatientsReport> ChssOrderPatientsReport { get; set; }
        public virtual ICollection<SsmtVerificationPatientData> SsmtVerificationPatientData { get; set; }
        public virtual ICollection<TreatmentPatientSummary> TreatmentPatientSummary { get; set; }
    }
}
