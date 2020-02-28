using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssMArtPatientCareTreatment
    {
        public int FacilityCode { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public int? DistrrictCode { get; set; }
        public string DistrictName { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public string ImplimentingPartnerDescription { get; set; }
        public int? ComprehensiveImplimentingPartnerCode { get; set; }
        public string ComprehensiveImplimentingPartnerDescription { get; set; }
        public int? LevelOfCare { get; set; }
        public string LevelDesc { get; set; }
        public int? CdcregionId { get; set; }
        public string Cdcregion { get; set; }
        public string Scto { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int RegimenClassificationCode { get; set; }
        public string RegimenClassificationDesc { get; set; }
        public string Drug1 { get; set; }
        public int Score1 { get; set; }
        public string Drug2 { get; set; }
        public int Score2 { get; set; }
        public string Drug3 { get; set; }
        public int Score3 { get; set; }
        public string Drug4 { get; set; }
        public int Score4 { get; set; }
        public string Drug5 { get; set; }
        public int Score5 { get; set; }
        public string Drug6 { get; set; }
        public int Score6 { get; set; }
        public string Drug7 { get; set; }
        public int Score7 { get; set; }
        public string Drug8 { get; set; }
        public int Score8 { get; set; }
        public string Drug9 { get; set; }
        public int Score9 { get; set; }
        public string Drug10 { get; set; }
        public int Score10 { get; set; }
        public int? TotalScore { get; set; }
    }
}
