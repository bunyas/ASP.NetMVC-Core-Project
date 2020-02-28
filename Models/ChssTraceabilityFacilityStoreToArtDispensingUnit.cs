using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssTraceabilityFacilityStoreToArtDispensingUnit
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int ProductCode { get; set; }
        public string Packsize { get; set; }
        public int? Availability { get; set; }
        public DateTime? IssueDate { get; set; }
        public int? QuantityIssued { get; set; }
        public DateTime? StockCardIssueDate { get; set; }
        public int? StockCardQuantityIssued { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual AProduct ProductCodeNavigation { get; set; }
    }
}
