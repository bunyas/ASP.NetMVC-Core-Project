using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDistSchedule
    {
        public bool? Select { get; set; }
        public string DistrictName { get; set; }
        public string DeliveryZoneCode { get; set; }
        public int FacilityCode { get; set; }
        public string Facility { get; set; }
        public string LevelOfCare { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ExpectedDateAtSite { get; set; }
        public int? StatusId { get; set; }
        public DateTime? ActualDateAtSite { get; set; }
        public int? StatusDeliveyId { get; set; }
        public string MaulStaff { get; set; }
        public string VehicleRegistration { get; set; }
        public string DriverPermitNumber { get; set; }
        public string Remark { get; set; }
        public double? TotalWeightCartons { get; set; }
        public double? TotalNoCartons { get; set; }
    }
}
