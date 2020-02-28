using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistIncidentReportWitness
    {
        public int WitnessCode { get; set; }
        public string OperatorPermit { get; set; }
        public DateTime DateOfIncident { get; set; }
        public string VehicleRegistartion { get; set; }
        public string WitnessName { get; set; }
        public int? WitnessContact { get; set; }
        public string WitnessAddress { get; set; }

        public virtual DistIncidentReport DistIncidentReport { get; set; }
    }
}
