using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisConArvX
    {
        public DateTime? EndDate { get; set; }
        public int DrugCode { get; set; }
        public DateTime? StartDate { get; set; }
        public int? FacilityCode { get; set; }
        public double ArtConsumption { get; set; }
        public string OrderNumber { get; set; }
    }
}
