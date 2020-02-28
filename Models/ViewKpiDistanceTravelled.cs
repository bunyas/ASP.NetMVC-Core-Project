using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewKpiDistanceTravelled
    {
        public string VehicleRegistration { get; set; }
        public int? SelectedMonth { get; set; }
        public int? SelectedYear { get; set; }
        public DateTime? FirstDay { get; set; }
        public DateTime? LastDay { get; set; }
    }
}
