using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class WebTemplateHivTestKitsNew
    {
        public int ProductOrder { get; set; }
        public int? ProductNubering { get; set; }
        public int? ProductCode { get; set; }
        public string ItemDescription { get; set; }
        public string BasicUnit { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
