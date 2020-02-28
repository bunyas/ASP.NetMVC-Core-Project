using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssOrderPatientsReport
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public short RegimenCode { get; set; }
        public int RegimenClassificationCode { get; set; }
        public int? Availability { get; set; }
        public int? OrderForm { get; set; }
        public int? ArtRegister { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual ADrugRegimenClassification RegimenClassificationCodeNavigation { get; set; }
        public virtual ADrugRegimen RegimenCodeNavigation { get; set; }
    }
}
