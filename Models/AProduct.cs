using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AProduct
    {
        public AProduct()
        {
            ChssFrostStockMovementOptions = new HashSet<ChssFrostStockMovementOptions>();
            ChssOrderAccuracy = new HashSet<ChssOrderAccuracy>();
            ChssOrderBalanceComparison = new HashSet<ChssOrderBalanceComparison>();
            ChssOrderTestKits = new HashSet<ChssOrderTestKits>();
            ChssStockManagement = new HashSet<ChssStockManagement>();
            ChssTraceabilityFacilityStoreToArtDispensingUnit = new HashSet<ChssTraceabilityFacilityStoreToArtDispensingUnit>();
            ChssTraceabilitySupplierToFacilityStore = new HashSet<ChssTraceabilitySupplierToFacilityStore>();
            OrderDrugDetails = new HashSet<OrderDrugDetails>();
            OrderDrugDetailsAmc = new HashSet<OrderDrugDetailsAmc>();
            OrderDrugDetailsEmergency = new HashSet<OrderDrugDetailsEmergency>();
            OrderDrugDetailsPhysicalCount = new HashSet<OrderDrugDetailsPhysicalCount>();
            OrderHivRapidTestKit = new HashSet<OrderHivRapidTestKit>();
            OrderHivRapidTestKitAmc = new HashSet<OrderHivRapidTestKitAmc>();
            OrderHivRapidTestKitEmergency = new HashSet<OrderHivRapidTestKitEmergency>();
            OrderHivRapidTestKitPhysicalCount = new HashSet<OrderHivRapidTestKitPhysicalCount>();
            OrderHivRapidTestKitSummary = new HashSet<OrderHivRapidTestKitSummary>();
            OrderLabCustom = new HashSet<OrderLabCustom>();
            OrderMault = new HashSet<OrderMault>();
            OrderOiStiDetail = new HashSet<OrderOiStiDetail>();
            OrderOiStiDetailPhysicalCount = new HashSet<OrderOiStiDetailPhysicalCount>();
            OrderOiStiEmergency = new HashSet<OrderOiStiEmergency>();
            OrderPrepdetails = new HashSet<OrderPrepdetails>();
            OrderRutfDetails = new HashSet<OrderRutfDetails>();
            OrderSmc = new HashSet<OrderSmc>();
            OrderSmcSlm = new HashSet<OrderSmcSlm>();
            OrderSmcSlmPhysicalCount = new HashSet<OrderSmcSlmPhysicalCount>();
            OrderTb = new HashSet<OrderTb>();
            OrderViralLoadReagentsDetail = new HashSet<OrderViralLoadReagentsDetail>();
            ProcPriceSupplier = new HashSet<ProcPriceSupplier>();
            SsmtStockManagementPractices = new HashSet<SsmtStockManagementPractices>();
            SsmtStockManagementTools = new HashSet<SsmtStockManagementTools>();
            SsmtVerificationLmisData = new HashSet<SsmtVerificationLmisData>();
        }

        public int ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Strength { get; set; }
        public string Packsize { get; set; }
        public int? CartonSizePkt { get; set; }
        public double? CartonWeightKg { get; set; }
        public int? ProductCategory { get; set; }
        public short? BasicUnit { get; set; }
        public bool? ApprovedMohNtg { get; set; }
        public bool? ApprovedWho { get; set; }
        public bool? ApprovedFda { get; set; }
        public int? NdaRegistration { get; set; }
        public string SapCode { get; set; }
        public bool? ConsummableProduct { get; set; }
        public int? ArtProductClassification { get; set; }
        public string NmsCodes { get; set; }
        public int? ProductStatusId { get; set; }
        public bool? ProductExpires { get; set; }
        public bool? TracerCommodity { get; set; }
        public int? ProductTypeId { get; set; }
        public int? ProductClassification { get; set; }

        public virtual ADrugBasicUnit BasicUnitNavigation { get; set; }
        public virtual AProductCategory ProductCategoryNavigation { get; set; }
        public virtual AProductClassification ProductClassificationNavigation { get; set; }
        public virtual AProductStatus ProductStatus { get; set; }
        public virtual AProductType ProductType { get; set; }
        public virtual ICollection<ChssFrostStockMovementOptions> ChssFrostStockMovementOptions { get; set; }
        public virtual ICollection<ChssOrderAccuracy> ChssOrderAccuracy { get; set; }
        public virtual ICollection<ChssOrderBalanceComparison> ChssOrderBalanceComparison { get; set; }
        public virtual ICollection<ChssOrderTestKits> ChssOrderTestKits { get; set; }
        public virtual ICollection<ChssStockManagement> ChssStockManagement { get; set; }
        public virtual ICollection<ChssTraceabilityFacilityStoreToArtDispensingUnit> ChssTraceabilityFacilityStoreToArtDispensingUnit { get; set; }
        public virtual ICollection<ChssTraceabilitySupplierToFacilityStore> ChssTraceabilitySupplierToFacilityStore { get; set; }
        public virtual ICollection<OrderDrugDetails> OrderDrugDetails { get; set; }
        public virtual ICollection<OrderDrugDetailsAmc> OrderDrugDetailsAmc { get; set; }
        public virtual ICollection<OrderDrugDetailsEmergency> OrderDrugDetailsEmergency { get; set; }
        public virtual ICollection<OrderDrugDetailsPhysicalCount> OrderDrugDetailsPhysicalCount { get; set; }
        public virtual ICollection<OrderHivRapidTestKit> OrderHivRapidTestKit { get; set; }
        public virtual ICollection<OrderHivRapidTestKitAmc> OrderHivRapidTestKitAmc { get; set; }
        public virtual ICollection<OrderHivRapidTestKitEmergency> OrderHivRapidTestKitEmergency { get; set; }
        public virtual ICollection<OrderHivRapidTestKitPhysicalCount> OrderHivRapidTestKitPhysicalCount { get; set; }
        public virtual ICollection<OrderHivRapidTestKitSummary> OrderHivRapidTestKitSummary { get; set; }
        public virtual ICollection<OrderLabCustom> OrderLabCustom { get; set; }
        public virtual ICollection<OrderMault> OrderMault { get; set; }
        public virtual ICollection<OrderOiStiDetail> OrderOiStiDetail { get; set; }
        public virtual ICollection<OrderOiStiDetailPhysicalCount> OrderOiStiDetailPhysicalCount { get; set; }
        public virtual ICollection<OrderOiStiEmergency> OrderOiStiEmergency { get; set; }
        public virtual ICollection<OrderPrepdetails> OrderPrepdetails { get; set; }
        public virtual ICollection<OrderRutfDetails> OrderRutfDetails { get; set; }
        public virtual ICollection<OrderSmc> OrderSmc { get; set; }
        public virtual ICollection<OrderSmcSlm> OrderSmcSlm { get; set; }
        public virtual ICollection<OrderSmcSlmPhysicalCount> OrderSmcSlmPhysicalCount { get; set; }
        public virtual ICollection<OrderTb> OrderTb { get; set; }
        public virtual ICollection<OrderViralLoadReagentsDetail> OrderViralLoadReagentsDetail { get; set; }
        public virtual ICollection<ProcPriceSupplier> ProcPriceSupplier { get; set; }
        public virtual ICollection<SsmtStockManagementPractices> SsmtStockManagementPractices { get; set; }
        public virtual ICollection<SsmtStockManagementTools> SsmtStockManagementTools { get; set; }
        public virtual ICollection<SsmtVerificationLmisData> SsmtVerificationLmisData { get; set; }
    }
}
