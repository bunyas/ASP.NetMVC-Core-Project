using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class TreatmentPatientSummary
    {
        public string OrderNumber { get; set; }
        public short RegimenCode { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? PatientsExisting { get; set; }
        public int? PatientsNew { get; set; }
        public int? PregnantExisting { get; set; }
        public int? PregnantNew { get; set; }
        public int? Existing03yrs { get; set; }
        public int? New03yrs { get; set; }
        public int? Existing310yrs { get; set; }
        public int? New310yrs { get; set; }
        public int? Existing1015yrsLess35Kg { get; set; }
        public int? New1015yrsLess35Kg { get; set; }
        public int? Existing1015yrsGreater35Kg { get; set; }
        public int? New1015yrsGreater35Kg { get; set; }

        public virtual OrderHeader OrderNumberNavigation { get; set; }
        public virtual ADrugRegimen RegimenCodeNavigation { get; set; }
    }
}
