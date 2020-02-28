using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssMArtPatientCareAvailability
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public int? DistrrictCode { get; set; }
        public string DistrictName { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public string ImplimentingPartnerDescription { get; set; }
        public int? LevelOfCare { get; set; }
        public string LevelDesc { get; set; }
        public int? CdcregionId { get; set; }
        public string Cdcregion { get; set; }
        public int? ComprehensiveImplimentingPartnerCode { get; set; }
        public string ComprehensiveImplimentingPartnerDescription { get; set; }
        public string Scto { get; set; }
        public int QOne { get; set; }
        public int QTwo { get; set; }
        public int QThree { get; set; }
        public int QFour { get; set; }
        public int QFive { get; set; }
        public int QSix { get; set; }
        public int QSeven { get; set; }
        public int QEight { get; set; }
        public int QNine { get; set; }
        public int QTen { get; set; }
        public int? Sum { get; set; }
        public decimal? Percentage { get; set; }
    }
}
