using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDistKpiRunningCost
    {
        public string VehicleRegistration { get; set; }
        public int? Byear { get; set; }
        public int? Bmonth { get; set; }
        public int? KilometresTravelled { get; set; }
        public int? FuelAdded { get; set; }
        public int? FuelUnitCost { get; set; }
    }
}
