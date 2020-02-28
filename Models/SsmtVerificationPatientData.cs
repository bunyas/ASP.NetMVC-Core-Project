using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SsmtVerificationPatientData
    {
        public int FacilityId { get; set; }
        public DateTime DateVisit { get; set; }
        public short RegimenCode { get; set; }
        public int? ExistingArtRegister { get; set; }
        public int? ExistingLmisReport { get; set; }
        public int? NewArtRegister { get; set; }
        public int? NewLmisReport { get; set; }
        public int? PatientDataTally { get; set; }
        public int? MaxScore { get; set; }
        public int? Score { get; set; }

        public virtual ADrugRegimen RegimenCodeNavigation { get; set; }
        public virtual SsmtFacility SsmtFacility { get; set; }
    }
}
