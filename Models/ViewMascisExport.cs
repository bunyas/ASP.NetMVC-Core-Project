using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewMascisExport
    {
        public bool? MyCheck { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public string LevelOfCare { get; set; }
        public string Facility { get; set; }
        public int? DistrrictCode { get; set; }
        public int FacilityId { get; set; }
        public DateTime DateVisit { get; set; }
        public DateTime? DateNextVisit { get; set; }
    }
}
