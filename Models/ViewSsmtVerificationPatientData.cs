using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewSsmtVerificationPatientData
    {
        public int RegimenClassificationCode { get; set; }
        public short RegimenCategoryCode { get; set; }
        public short RegimenCode { get; set; }
        public string RegimenClassificationDesc { get; set; }
        public string RegimenCategoryDesc { get; set; }
        public string RegimenDesc { get; set; }
        public string ExistingArtRegister { get; set; }
        public string ExistingLmisReport { get; set; }
        public string NewArtRegister { get; set; }
        public string NewLmisReport { get; set; }
        public string PatientDataTally { get; set; }
        public int? MaxScore { get; set; }
        public int? Score { get; set; }
        public bool? StandardRegimen { get; set; }
    }
}
