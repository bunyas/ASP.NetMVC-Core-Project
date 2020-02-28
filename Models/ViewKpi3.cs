using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewKpi3
    {
        public string VehicleRegistration { get; set; }
        public int? SelectedMonth { get; set; }
        public int? SelectedYear { get; set; }
        public int? FuelAdded { get; set; }
        public int? FuelCost { get; set; }
        public int? DaysInWorkhop { get; set; }
        public int? LabourCost { get; set; }
        public int? TotalCost { get; set; }
        public DateTime? FirstDay { get; set; }
        public DateTime? LastDay { get; set; }
    }
}
