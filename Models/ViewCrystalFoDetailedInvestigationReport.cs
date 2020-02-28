using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewCrystalFoDetailedInvestigationReport
    {
        public int ERegComplaintCode { get; set; }
        public string ERegComplaintNo { get; set; }
        public DateTime? ERegDateRecieved { get; set; }
        public int FacilityCode { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public int ProductCode { get; set; }
        public string BatchNo { get; set; }
        public string ProductDescription { get; set; }
        public string CategoryDesc { get; set; }
        public string ProductWellHandled { get; set; }
        public string ProductProperlyUsed { get; set; }
        public string ProductProperlyTransported { get; set; }
        public string CommonProblem { get; set; }
        public string WarehouseQuarantine { get; set; }
        public string FacilityQuarantine { get; set; }
        public string DiferShipment { get; set; }
        public string CancelShipment { get; set; }
        public string SwitchProduct { get; set; }
        public string ObtainReplacement { get; set; }
        public string RecallProduct { get; set; }
        public string ReferSample { get; set; }
        public string ConductGmp { get; set; }
        public string InvolveNda { get; set; }
        public string OtherAction { get; set; }
    }
}
