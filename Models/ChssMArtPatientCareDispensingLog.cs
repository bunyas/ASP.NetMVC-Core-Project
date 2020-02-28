using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssMArtPatientCareDispensingLog
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int LogNo { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public int? LevelOfCare { get; set; }
        public string LevelDesc { get; set; }
        public int? CdcregionId { get; set; }
        public string Cdcregion { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public string ImplimentingPartnerDescription { get; set; }
        public int? DistrrictCode { get; set; }
        public string DistrictName { get; set; }
        public int? ComprehensiveImplimentingPartnerCode { get; set; }
        public string ComprehensiveImplimentingPartnerDescription { get; set; }
        public string Scto { get; set; }
        public string DispensingDate { get; set; }
        public string PatientNo { get; set; }
        public string MedicineName { get; set; }
        public string AmountDispensed { get; set; }
        public int? Score { get; set; }
    }
}
