using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisAllocationNArvSum
    {
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int DrugCode { get; set; }
        public double? QuantityAllocated { get; set; }
        public double? ArtEMtctConsumption { get; set; }
        public double? AdjustedAmc { get; set; }
        public double? DaysOutOfStockDuring2Months { get; set; }
    }
}
