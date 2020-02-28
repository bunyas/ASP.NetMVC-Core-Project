using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AFacilities
    {
        public AFacilities()
        {
            ASectorChange = new HashSet<ASectorChange>();
            ApprovedFacilityOrders = new HashSet<ApprovedFacilityOrders>();
            AspNetUsers1 = new HashSet<AspNetUsers1>();
            ChssAreasVisited = new HashSet<ChssAreasVisited>();
            ChssArtPatientCareRegister = new HashSet<ChssArtPatientCareRegister>();
            ChssArtPatientDispensingLog = new HashSet<ChssArtPatientDispensingLog>();
            ChssArtPatientToolAvailability = new HashSet<ChssArtPatientToolAvailability>();
            ChssArtPatientTreatementGuide = new HashSet<ChssArtPatientTreatementGuide>();
            ChssComments = new HashSet<ChssComments>();
            ChssEquipmentVerification = new HashSet<ChssEquipmentVerification>();
            ChssExpiryFefoUse = new HashSet<ChssExpiryFefoUse>();
            ChssExpiryPresence = new HashSet<ChssExpiryPresence>();
            ChssExpiryTrackingTools = new HashSet<ChssExpiryTrackingTools>();
            ChssFacilityDetails = new HashSet<ChssFacilityDetails>();
            ChssFeedBackActionArea = new HashSet<ChssFeedBackActionArea>();
            ChssFeedBackPharmacovigilenceSolution = new HashSet<ChssFeedBackPharmacovigilenceSolution>();
            ChssFeedBackReport = new HashSet<ChssFeedBackReport>();
            ChssFeedBackSolution = new HashSet<ChssFeedBackSolution>();
            ChssFrostStockMovementOptions = new HashSet<ChssFrostStockMovementOptions>();
            ChssOrderAccuracy = new HashSet<ChssOrderAccuracy>();
            ChssOrderBalanceComparison = new HashSet<ChssOrderBalanceComparison>();
            ChssOrderMeans = new HashSet<ChssOrderMeans>();
            ChssOrderPatientsReport = new HashSet<ChssOrderPatientsReport>();
            ChssOrderTestKits = new HashSet<ChssOrderTestKits>();
            ChssScore = new HashSet<ChssScore>();
            ChssStockManagement = new HashSet<ChssStockManagement>();
            ChssStorageCondition = new HashSet<ChssStorageCondition>();
            ChssStoragePractice = new HashSet<ChssStoragePractice>();
            ChssStorageSystem = new HashSet<ChssStorageSystem>();
            ChssStoreCleanliness = new HashSet<ChssStoreCleanliness>();
            ChssSupervisor = new HashSet<ChssSupervisor>();
            ChssSync = new HashSet<ChssSync>();
            ChssTraceabilityFacilityStoreToArtDispensingUnit = new HashSet<ChssTraceabilityFacilityStoreToArtDispensingUnit>();
            ChssTraceabilityIssuedToPatients = new HashSet<ChssTraceabilityIssuedToPatients>();
            ChssTraceabilityRequisitioningSystem = new HashSet<ChssTraceabilityRequisitioningSystem>();
            ChssTraceabilitySpecialisation = new HashSet<ChssTraceabilitySpecialisation>();
            ChssTraceabilitySupplierToFacilityStore = new HashSet<ChssTraceabilitySupplierToFacilityStore>();
            DistLogbookDestinationFacilityNavigation = new HashSet<DistLogbook>();
            DistLogbookSourceFacilityNavigation = new HashSet<DistLogbook>();
            FoClientFeedback = new HashSet<FoClientFeedback>();
            FoComplaint = new HashSet<FoComplaint>();
            FoComplaintAffectedSites = new HashSet<FoComplaintAffectedSites>();
            FoContactPerson = new HashSet<FoContactPerson>();
            HssBaselineBulkStore = new HashSet<HssBaselineBulkStore>();
            HssBaselineFocusGroupDiscussion = new HashSet<HssBaselineFocusGroupDiscussion>();
            HssBaselineLmis = new HashSet<HssBaselineLmis>();
            LmisExpectedReport = new HashSet<LmisExpectedReport>();
            MileageFormDestinationNavigation = new HashSet<MileageForm>();
            MileageFormLocationNavigation = new HashSet<MileageForm>();
            OrderDrugDetailsAmc = new HashSet<OrderDrugDetailsAmc>();
            OrderDrugDetailsEmergency = new HashSet<OrderDrugDetailsEmergency>();
            OrderDrugDetailsPhysicalCount = new HashSet<OrderDrugDetailsPhysicalCount>();
            OrderHeader = new HashSet<OrderHeader>();
            OrderHivRapidTestKitAmc = new HashSet<OrderHivRapidTestKitAmc>();
            OrderHivRapidTestKitEmergency = new HashSet<OrderHivRapidTestKitEmergency>();
            OrderHivRapidTestKitHeader = new HashSet<OrderHivRapidTestKitHeader>();
            OrderHivRapidTestKitPhysicalCount = new HashSet<OrderHivRapidTestKitPhysicalCount>();
            OrderLabAmc = new HashSet<OrderLabAmc>();
            OrderLabCustomHeader = new HashSet<OrderLabCustomHeader>();
            OrderLabEmergency = new HashSet<OrderLabEmergency>();
            OrderLabHeader = new HashSet<OrderLabHeader>();
            OrderLabPhysicalCount = new HashSet<OrderLabPhysicalCount>();
            OrderMaultHeader = new HashSet<OrderMaultHeader>();
            OrderOiStiDetailPhysicalCount = new HashSet<OrderOiStiDetailPhysicalCount>();
            OrderOiStiEmergency = new HashSet<OrderOiStiEmergency>();
            OrderOiStiHeader = new HashSet<OrderOiStiHeader>();
            OrderPrepHeader = new HashSet<OrderPrepHeader>();
            OrderRutfHeader = new HashSet<OrderRutfHeader>();
            OrderSmcHeader = new HashSet<OrderSmcHeader>();
            OrderSmcSlmEmergency = new HashSet<OrderSmcSlmEmergency>();
            OrderSmcSlmHeader = new HashSet<OrderSmcSlmHeader>();
            OrderSmcSlmPhysicalCount = new HashSet<OrderSmcSlmPhysicalCount>();
            OrderSmcSlmSummary = new HashSet<OrderSmcSlmSummary>();
            OrderTbHeader = new HashSet<OrderTbHeader>();
            OrderViralLoadReagentsEmergency = new HashSet<OrderViralLoadReagentsEmergency>();
            OrderViralLoadReagentsHeader = new HashSet<OrderViralLoadReagentsHeader>();
            OrderViralLoadReagentsSummary = new HashSet<OrderViralLoadReagentsSummary>();
            PhysicalCountDetails = new HashSet<PhysicalCountDetails>();
            PhysicalCountHeader = new HashSet<PhysicalCountHeader>();
            SsmtFacility = new HashSet<SsmtFacility>();
            TreatmentFluconazole = new HashSet<TreatmentFluconazole>();
        }

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
        public bool ActiveArt { get; set; }

        public virtual ACdcregion Cdcregion { get; set; }
        public virtual AClientType ClientTypeCodeNavigation { get; set; }
        public virtual AImplimentingPartners ComprehensiveImplimentingPartnerCodeNavigation { get; set; }
        public virtual ADeliveryZone DeliveryZoneCodeNavigation { get; set; }
        public virtual ADistrict DistrrictCodeNavigation { get; set; }
        public virtual AFacilityType FacilityType { get; set; }
        public virtual AFacilityLevelOfCare LevelOfCareNavigation { get; set; }
        public virtual AOwnership Ownership { get; set; }
        public virtual APatientLoad PatientLoadCodeNavigation { get; set; }
        public virtual AVillage Village { get; set; }
        public virtual ChssFacilityContacts ChssFacilityContacts { get; set; }
        public virtual ICollection<ASectorChange> ASectorChange { get; set; }
        public virtual ICollection<ApprovedFacilityOrders> ApprovedFacilityOrders { get; set; }
        public virtual ICollection<AspNetUsers1> AspNetUsers1 { get; set; }
        public virtual ICollection<ChssAreasVisited> ChssAreasVisited { get; set; }
        public virtual ICollection<ChssArtPatientCareRegister> ChssArtPatientCareRegister { get; set; }
        public virtual ICollection<ChssArtPatientDispensingLog> ChssArtPatientDispensingLog { get; set; }
        public virtual ICollection<ChssArtPatientToolAvailability> ChssArtPatientToolAvailability { get; set; }
        public virtual ICollection<ChssArtPatientTreatementGuide> ChssArtPatientTreatementGuide { get; set; }
        public virtual ICollection<ChssComments> ChssComments { get; set; }
        public virtual ICollection<ChssEquipmentVerification> ChssEquipmentVerification { get; set; }
        public virtual ICollection<ChssExpiryFefoUse> ChssExpiryFefoUse { get; set; }
        public virtual ICollection<ChssExpiryPresence> ChssExpiryPresence { get; set; }
        public virtual ICollection<ChssExpiryTrackingTools> ChssExpiryTrackingTools { get; set; }
        public virtual ICollection<ChssFacilityDetails> ChssFacilityDetails { get; set; }
        public virtual ICollection<ChssFeedBackActionArea> ChssFeedBackActionArea { get; set; }
        public virtual ICollection<ChssFeedBackPharmacovigilenceSolution> ChssFeedBackPharmacovigilenceSolution { get; set; }
        public virtual ICollection<ChssFeedBackReport> ChssFeedBackReport { get; set; }
        public virtual ICollection<ChssFeedBackSolution> ChssFeedBackSolution { get; set; }
        public virtual ICollection<ChssFrostStockMovementOptions> ChssFrostStockMovementOptions { get; set; }
        public virtual ICollection<ChssOrderAccuracy> ChssOrderAccuracy { get; set; }
        public virtual ICollection<ChssOrderBalanceComparison> ChssOrderBalanceComparison { get; set; }
        public virtual ICollection<ChssOrderMeans> ChssOrderMeans { get; set; }
        public virtual ICollection<ChssOrderPatientsReport> ChssOrderPatientsReport { get; set; }
        public virtual ICollection<ChssOrderTestKits> ChssOrderTestKits { get; set; }
        public virtual ICollection<ChssScore> ChssScore { get; set; }
        public virtual ICollection<ChssStockManagement> ChssStockManagement { get; set; }
        public virtual ICollection<ChssStorageCondition> ChssStorageCondition { get; set; }
        public virtual ICollection<ChssStoragePractice> ChssStoragePractice { get; set; }
        public virtual ICollection<ChssStorageSystem> ChssStorageSystem { get; set; }
        public virtual ICollection<ChssStoreCleanliness> ChssStoreCleanliness { get; set; }
        public virtual ICollection<ChssSupervisor> ChssSupervisor { get; set; }
        public virtual ICollection<ChssSync> ChssSync { get; set; }
        public virtual ICollection<ChssTraceabilityFacilityStoreToArtDispensingUnit> ChssTraceabilityFacilityStoreToArtDispensingUnit { get; set; }
        public virtual ICollection<ChssTraceabilityIssuedToPatients> ChssTraceabilityIssuedToPatients { get; set; }
        public virtual ICollection<ChssTraceabilityRequisitioningSystem> ChssTraceabilityRequisitioningSystem { get; set; }
        public virtual ICollection<ChssTraceabilitySpecialisation> ChssTraceabilitySpecialisation { get; set; }
        public virtual ICollection<ChssTraceabilitySupplierToFacilityStore> ChssTraceabilitySupplierToFacilityStore { get; set; }
        public virtual ICollection<DistLogbook> DistLogbookDestinationFacilityNavigation { get; set; }
        public virtual ICollection<DistLogbook> DistLogbookSourceFacilityNavigation { get; set; }
        public virtual ICollection<FoClientFeedback> FoClientFeedback { get; set; }
        public virtual ICollection<FoComplaint> FoComplaint { get; set; }
        public virtual ICollection<FoComplaintAffectedSites> FoComplaintAffectedSites { get; set; }
        public virtual ICollection<FoContactPerson> FoContactPerson { get; set; }
        public virtual ICollection<HssBaselineBulkStore> HssBaselineBulkStore { get; set; }
        public virtual ICollection<HssBaselineFocusGroupDiscussion> HssBaselineFocusGroupDiscussion { get; set; }
        public virtual ICollection<HssBaselineLmis> HssBaselineLmis { get; set; }
        public virtual ICollection<LmisExpectedReport> LmisExpectedReport { get; set; }
        public virtual ICollection<MileageForm> MileageFormDestinationNavigation { get; set; }
        public virtual ICollection<MileageForm> MileageFormLocationNavigation { get; set; }
        public virtual ICollection<OrderDrugDetailsAmc> OrderDrugDetailsAmc { get; set; }
        public virtual ICollection<OrderDrugDetailsEmergency> OrderDrugDetailsEmergency { get; set; }
        public virtual ICollection<OrderDrugDetailsPhysicalCount> OrderDrugDetailsPhysicalCount { get; set; }
        public virtual ICollection<OrderHeader> OrderHeader { get; set; }
        public virtual ICollection<OrderHivRapidTestKitAmc> OrderHivRapidTestKitAmc { get; set; }
        public virtual ICollection<OrderHivRapidTestKitEmergency> OrderHivRapidTestKitEmergency { get; set; }
        public virtual ICollection<OrderHivRapidTestKitHeader> OrderHivRapidTestKitHeader { get; set; }
        public virtual ICollection<OrderHivRapidTestKitPhysicalCount> OrderHivRapidTestKitPhysicalCount { get; set; }
        public virtual ICollection<OrderLabAmc> OrderLabAmc { get; set; }
        public virtual ICollection<OrderLabCustomHeader> OrderLabCustomHeader { get; set; }
        public virtual ICollection<OrderLabEmergency> OrderLabEmergency { get; set; }
        public virtual ICollection<OrderLabHeader> OrderLabHeader { get; set; }
        public virtual ICollection<OrderLabPhysicalCount> OrderLabPhysicalCount { get; set; }
        public virtual ICollection<OrderMaultHeader> OrderMaultHeader { get; set; }
        public virtual ICollection<OrderOiStiDetailPhysicalCount> OrderOiStiDetailPhysicalCount { get; set; }
        public virtual ICollection<OrderOiStiEmergency> OrderOiStiEmergency { get; set; }
        public virtual ICollection<OrderOiStiHeader> OrderOiStiHeader { get; set; }
        public virtual ICollection<OrderPrepHeader> OrderPrepHeader { get; set; }
        public virtual ICollection<OrderRutfHeader> OrderRutfHeader { get; set; }
        public virtual ICollection<OrderSmcHeader> OrderSmcHeader { get; set; }
        public virtual ICollection<OrderSmcSlmEmergency> OrderSmcSlmEmergency { get; set; }
        public virtual ICollection<OrderSmcSlmHeader> OrderSmcSlmHeader { get; set; }
        public virtual ICollection<OrderSmcSlmPhysicalCount> OrderSmcSlmPhysicalCount { get; set; }
        public virtual ICollection<OrderSmcSlmSummary> OrderSmcSlmSummary { get; set; }
        public virtual ICollection<OrderTbHeader> OrderTbHeader { get; set; }
        public virtual ICollection<OrderViralLoadReagentsEmergency> OrderViralLoadReagentsEmergency { get; set; }
        public virtual ICollection<OrderViralLoadReagentsHeader> OrderViralLoadReagentsHeader { get; set; }
        public virtual ICollection<OrderViralLoadReagentsSummary> OrderViralLoadReagentsSummary { get; set; }
        public virtual ICollection<PhysicalCountDetails> PhysicalCountDetails { get; set; }
        public virtual ICollection<PhysicalCountHeader> PhysicalCountHeader { get; set; }
        public virtual ICollection<SsmtFacility> SsmtFacility { get; set; }
        public virtual ICollection<TreatmentFluconazole> TreatmentFluconazole { get; set; }
    }
}
