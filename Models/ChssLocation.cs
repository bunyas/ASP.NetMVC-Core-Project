using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssLocation
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string StartPlace { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public double? EndLong { get; set; }
        public double? EndLat { get; set; }
        public string EndPlace { get; set; }
    }
}
