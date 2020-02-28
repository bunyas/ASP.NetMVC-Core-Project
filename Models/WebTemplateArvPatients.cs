using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class WebTemplateArvPatients
    {
        public int ProductOrder { get; set; }
        public short? RegimenCode { get; set; }
        public string Regimen { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Classification { get; set; }
    }
}
