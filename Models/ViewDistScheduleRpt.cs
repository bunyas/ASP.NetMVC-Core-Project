using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDistScheduleRpt
    {
        public string DistrictName { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public string LevelOfCare { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime? ExpectedDateAtSite { get; set; }
        public string StatusDesc { get; set; }
        public DateTime? ActualDateAtSite { get; set; }
        public string StatusDelivey { get; set; }
        public string MaulStaff { get; set; }
        public string VehicleRegistration { get; set; }
        public string DriverPermitNumber { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public double? TotalNoCartons { get; set; }
        public double? TotalWeightCartons { get; set; }
    }
}
