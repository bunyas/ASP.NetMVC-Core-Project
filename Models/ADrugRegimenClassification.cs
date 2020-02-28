using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ADrugRegimenClassification
    {
        public ADrugRegimenClassification()
        {
            ADrugRegimen = new HashSet<ADrugRegimen>();
            ChssArtPatientTreatementGuide = new HashSet<ChssArtPatientTreatementGuide>();
            ChssOrderPatientsReport = new HashSet<ChssOrderPatientsReport>();
        }

        public int RegimenClassificationCode { get; set; }
        public string RegimenClassificationDesc { get; set; }

        public virtual ICollection<ADrugRegimen> ADrugRegimen { get; set; }
        public virtual ICollection<ChssArtPatientTreatementGuide> ChssArtPatientTreatementGuide { get; set; }
        public virtual ICollection<ChssOrderPatientsReport> ChssOrderPatientsReport { get; set; }
    }
}
