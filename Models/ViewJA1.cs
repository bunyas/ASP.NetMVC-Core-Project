using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewJA1
    {
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short RegimenCode { get; set; }
        public int? PatientsExisting { get; set; }
        public int? PatientsNew { get; set; }
        public int? PregnantExisting { get; set; }
        public int? PregnantNew { get; set; }
    }
}
