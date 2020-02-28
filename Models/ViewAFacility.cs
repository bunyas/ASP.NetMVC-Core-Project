using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewAFacility
    {
        public int FacilityCode { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public int? DistrrictCode { get; set; }
        public string Facility { get; set; }
        public string SapCode { get; set; }
        public bool? SupportedByMaul { get; set; }
        public bool? IsAccredited { get; set; }
        public int? LevelOfCare { get; set; }
        public int? ClientTypeCode { get; set; }
        public int? RegionCode { get; set; }
        public string RfsoUserName { get; set; }
        public int? OwnershipId { get; set; }
        public int? CdcregionId { get; set; }
        public string FacilityTypeId { get; set; }
        public string Longtitude { get; set; }
        public string Latititude { get; set; }
        public string VillageId { get; set; }
        public int? ComprehensiveImplimentingPartnerCode { get; set; }
        public int? PatientLoadCode { get; set; }
        public bool? IsActive { get; set; }
        public int? NearestPublicHfDistance { get; set; }
        public string Dsdm { get; set; }
        public string Scto { get; set; }
        public bool ActiveArt { get; set; }
    }
}
