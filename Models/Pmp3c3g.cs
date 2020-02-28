using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class Pmp3c3g
    {
        public string CopYear { get; set; }
        public int ProductId { get; set; }
        public int Period { get; set; }
        public string TaskOrder { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? NormalProcurement { get; set; }
        public double? EmergencyProcurement { get; set; }
        public double? TotalCostFobMaulPriceUsd { get; set; }
        public double? TotalOrderCostScmsUsd { get; set; }
        public double? TotalSavingBasedOnFob { get; set; }
    }
}
