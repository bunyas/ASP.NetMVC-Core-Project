using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewKpiAvialability
    {
        public int? YearRecorded { get; set; }
        public int? MonthRecorded { get; set; }
        public int? DaysInWorkhop { get; set; }
        public int? NoOfWorkingDays { get; set; }
        public double? Avialability { get; set; }
        public int? DaysIsAvialable { get; set; }
        public string Registration { get; set; }
    }
}
