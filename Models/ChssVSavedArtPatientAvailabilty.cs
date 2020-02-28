using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssVSavedArtPatientAvailabilty
    {
        public int FacilityCode { get; set; }
        public string Facility { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int SectorId { get; set; }
        public int GuidId { get; set; }
        public string Question { get; set; }
        public bool? Availability { get; set; }
    }
}
