using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisExpectedReport
    {
        public string Facility { get; set; }
        public int FacilityCode { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public string ZoneDescription { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string ProductCategory { get; set; }
        public int? ClientTypeCode { get; set; }
        public string ClientTypeDesc { get; set; }
        public int? CdcregionId { get; set; }
        public string Cdcregion { get; set; }
        public int? OwnershipId { get; set; }
        public string OwnershipDescription { get; set; }
        public string IsActive { get; set; }
    }
}
