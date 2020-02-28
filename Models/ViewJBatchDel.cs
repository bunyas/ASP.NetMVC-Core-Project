using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewJBatchDel
    {
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short RegimenCode { get; set; }
        public int? PatientsExisting { get; set; }
        public int? PatientsNew { get; set; }
        public int? PregnantExisting { get; set; }
        public int? PregnantNew { get; set; }
        public int? JMonth { get; set; }
        public int? JYear { get; set; }
        public int? Conflict { get; set; }
    }
}
