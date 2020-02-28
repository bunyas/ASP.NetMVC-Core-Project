using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewCConAmcSmc
    {
        public string XmYearMonth { get; set; }
        public DateTime EndDate { get; set; }
        public int FacilityCode { get; set; }
        public int? YearMonth { get; set; }
        public double Consumption { get; set; }
        public int ItemCode { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public int? DistrrictCode { get; set; }
        public bool? RecordStatus { get; set; }
        public double? Amc { get; set; }
        public string Facility { get; set; }
        public int? XYear { get; set; }
        public string ProductDescription { get; set; }
        public string Packsize { get; set; }
    }
}
