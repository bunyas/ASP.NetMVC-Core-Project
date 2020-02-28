using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewCrystalFoComplaint
    {
        public string ERegComplaintNo { get; set; }
        public int FacilityCode { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public string ZoneDescription { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public string DistrictName { get; set; }
        public string LevelofCare { get; set; }
        public string Cdcregion { get; set; }
        public string FacilityType { get; set; }
        public string ERegComplaintDetails { get; set; }
        public string CategoryDesc { get; set; }
        public string CommModeDesc { get; set; }
        public DateTime? ERegDateRecieved { get; set; }
        public DateTime? ERegExpectedDateResolution { get; set; }
        public DateTime? ERegDateResolved { get; set; }
        public string CommunicatedByLev1 { get; set; }
        public DateTime? CommunicatedByLev1Date { get; set; }
        public string CommunicatedByLev2 { get; set; }
        public DateTime? CommunicatedByLev2Date { get; set; }
        public string CommunicatedByLev3 { get; set; }
        public DateTime? FeedbackDate { get; set; }
        public string AccutenessDesc { get; set; }
        public string StatusDesc { get; set; }
        public int ERegComplaintCode { get; set; }
    }
}
