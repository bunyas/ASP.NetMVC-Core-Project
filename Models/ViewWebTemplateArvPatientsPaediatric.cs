using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewWebTemplateArvPatientsPaediatric
    {
        public int ProductOrder { get; set; }
        public short? RegimenCode { get; set; }
        public string Regimen { get; set; }
        public int NoExisting { get; set; }
        public int NoNew { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
