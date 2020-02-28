using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisSummaryStockoutArv
    {
        public int FacilityCode { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double Consumption { get; set; }
        public double MonthsOfStockAtHand { get; set; }
    }
}
