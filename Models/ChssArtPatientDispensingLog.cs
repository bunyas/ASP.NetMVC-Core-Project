using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssArtPatientDispensingLog
    {
        public int LogNo { get; set; }
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int? DispensingDate { get; set; }
        public int? PatientNo { get; set; }
        public int? MedicineName { get; set; }
        public int? AmountDispensed { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
    }
}
