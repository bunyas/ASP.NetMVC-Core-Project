using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDashChssConnectedToSap
    {
        public int FacilityCode { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public string Cdcregion { get; set; }
        public string DistrictName { get; set; }
        public string ZoneDescription { get; set; }
        public string LevelOfCare { get; set; }
        public string Scto { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int GuidId { get; set; }
        public string Question { get; set; }
        public bool? Result { get; set; }
    }
}
