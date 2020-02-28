using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewPalAmcArt
    {
        public int FacilityCode { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double? PmtctConsumption { get; set; }
        public double? ArtConsumption { get; set; }
        public double? ArtEMtctConsumption { get; set; }
        public int DrugCode { get; set; }
    }
}
