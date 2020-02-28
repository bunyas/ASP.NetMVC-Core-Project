using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisSummary
    {
        public string Category { get; set; }
        public int IndicatorCode { get; set; }
        public string IndicatorDesc { get; set; }
        public int? SubIndicatorCode { get; set; }
        public string SubIndicatorDesc { get; set; }
        public string ExpectedReports { get; set; }
        public string ReportsRecieved { get; set; }
        public string Percentage { get; set; }
        public string Number { get; set; }
    }
}
