using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDistKpiFuelConsumption
    {
        public string VehicleRegistration { get; set; }
        public int? Byear { get; set; }
        public int? Bmonth { get; set; }
        public int? KilometresTravelled { get; set; }
        public int? FuelAdded { get; set; }
        public double? FuelConsumption { get; set; }
    }
}
