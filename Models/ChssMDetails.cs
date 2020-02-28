using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssMDetails
    {
        public int FacilityCode { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public string ZoneDescription { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public bool? IsAccredited { get; set; }
        public int? OwnershipId { get; set; }
        public string OwnershipDescription { get; set; }
        public int? DistrrictCode { get; set; }
        public string DistrictName { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public int? LevelOfCare { get; set; }
        public string LevelDesc { get; set; }
        public string RegionDescription { get; set; }
        public int? CdcregionId { get; set; }
        public string Cdcregion { get; set; }
        public int? ComprehensiveImplimentingPartnerCode { get; set; }
        public string ComprehensiveImplimentingPartnerDescription { get; set; }
        public DateTime DateOfVisit { get; set; }
        public DateTime? NextPlannedVisit { get; set; }
        public int? VisitNo { get; set; }
        public string CapturedBy { get; set; }
        public DateTime? AdjustedDate { get; set; }
        public string AdjustedBy { get; set; }
        public string Reason { get; set; }
        public string FacilityInchargeName { get; set; }
        public string FacilityInchargeContact { get; set; }
        public string ArtInchargeName { get; set; }
        public string ArtInchargeContact { get; set; }
        public string PharmaconvigilenceName { get; set; }
        public string PharmaconvigilenceContact { get; set; }
        public string MmsName { get; set; }
        public string Scto { get; set; }
    }
}
