using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssTraceabilitySpecialisationView
    {
        public int FacilityCode { get; set; }
        public string Facility { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int ClassificationCode { get; set; }
        public string Description { get; set; }
        public bool? Result { get; set; }
    }
}
