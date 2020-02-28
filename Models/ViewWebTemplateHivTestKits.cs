using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewWebTemplateHivTestKits
    {
        public int ProductOrder { get; set; }
        public int? ProductCode { get; set; }
        public string BasicUnit { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double? NoTestStart2months { get; set; }
        public double? TestRecieved2months { get; set; }
        public double? TestUsed2months { get; set; }
        public double? LossAdjustment { get; set; }
        public double? TestRemaining { get; set; }
        public double? MaximumStock { get; set; }
        public double? QunatityOnOrder { get; set; }
        public double? QuantityRequired { get; set; }
        public string QuantityToShip { get; set; }
        public string Rfsonotes { get; set; }
        public double? QuantityAllocated { get; set; }
        public string ProductDescription { get; set; }
    }
}
