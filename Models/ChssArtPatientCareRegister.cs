using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssArtPatientCareRegister
    {
        public int RegisterNo { get; set; }
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int? StartDate { get; set; }
        public int? PatientNo { get; set; }
        public int? PatientName { get; set; }
        public int? PatientWeight { get; set; }
        public int? PatientAge { get; set; }
        public int? Dapsone { get; set; }
        public int? OriginalRegimen { get; set; }
        public int? CurrentRegimen { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
    }
}
