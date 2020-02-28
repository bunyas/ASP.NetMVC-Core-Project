using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewExportAtomicArvTreatmentPatientSummary
    {
        public string OrderNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? DatePrepared { get; set; }
        public bool? EmergencyOrder { get; set; }
        public bool? FinalSubmission { get; set; }
        public int? OrderTypeId { get; set; }
        public string OrderType { get; set; }
        public int? OrderStatusId { get; set; }
        public string Status { get; set; }
        public int? FacilityCode { get; set; }
        public string Facility { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public string ZoneDescription { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public int? DistrrictCode { get; set; }
        public string District { get; set; }
        public string SapCode { get; set; }
        public bool? SupportedByMaul { get; set; }
        public bool? IsAccredited { get; set; }
        public int? LevelOfCare { get; set; }
        public string LevelDesc { get; set; }
        public int? ClientTypeCode { get; set; }
        public string ClientTypeDesc { get; set; }
        public int? OwnershipId { get; set; }
        public string OwnershipDescription { get; set; }
        public int? CdcregionId { get; set; }
        public string Cdcregion { get; set; }
        public string FacilityTypeId { get; set; }
        public string FacilityType { get; set; }
        public int? ComprehensiveImplimentingPartnerCode { get; set; }
        public string ComprehensiveImplementingPartnerDescription { get; set; }
        public int? PatientLoadCode { get; set; }
        public string PatientLoadDescription { get; set; }
        public string Scto { get; set; }
        public bool? IsActive { get; set; }
        public short RegimenCode { get; set; }
        public string RegimenDesc { get; set; }
        public short? RegimenCategoryCode { get; set; }
        public string RegimenCategoryDesc { get; set; }
        public int? RegimenClassification { get; set; }
        public string RegimenClassificationDesc { get; set; }
        public bool? StandardRegimen { get; set; }
        public bool? IsExtra { get; set; }
        public int? PatientsExisting { get; set; }
        public int? PatientsNew { get; set; }
        public int? PregnantExisting { get; set; }
        public int? PregnantNew { get; set; }
        public int? Existing03yrs { get; set; }
        public int? New03yrs { get; set; }
        public int? Existing310yrs { get; set; }
        public int? New310yrs { get; set; }
        public int? Existing1015yrsLess35Kg { get; set; }
        public int? New1015yrsLess35Kg { get; set; }
        public int? Existing1015yrsGreater35Kg { get; set; }
        public int? New1015yrsGreater35Kg { get; set; }
    }
}
