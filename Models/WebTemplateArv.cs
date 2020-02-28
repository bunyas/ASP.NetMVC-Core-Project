using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class WebTemplateArv
    {
        public int ProductOrder { get; set; }
        public int? ProductCode { get; set; }
        public string ProductNumbering { get; set; }
        public string ProductDescription { get; set; }
        public string BasicUnit { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
