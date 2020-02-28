using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewPmpStockOutBase
    {
        public double ClosingBalance { get; set; }
        public double Consumption { get; set; }
        public double? MonthsStockAtHand { get; set; }
        public int DrugCode { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartDate { get; set; }
        public int? FacilityCode { get; set; }
    }
}
