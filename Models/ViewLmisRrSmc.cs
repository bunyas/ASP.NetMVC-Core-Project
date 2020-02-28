using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisRrSmc
    {
        public int? NoOfFacilities { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? FacilitiesSesctor { get; set; }
        public double? ReportingRatio { get; set; }
    }
}
