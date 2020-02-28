using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class Pmp5c
    {
        public string CopYear { get; set; }
        public string Period { get; set; }
        public DateTime MonthId { get; set; }
        public DateTime? LastActualDeliveryDate { get; set; }
        public DateTime? ScheduledDeliveryDate { get; set; }
        public int? AStatus { get; set; }
    }
}
