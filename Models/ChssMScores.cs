using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssMScores
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public string DistrictName { get; set; }
        public string ImplimentingPartnerDescription { get; set; }
        public int? LevelOfCare { get; set; }
        public string LevelDesc { get; set; }
        public int? CdcregionId { get; set; }
        public string Cdcregion { get; set; }
        public string Scto { get; set; }
        public string ArtAvailability { get; set; }
        public string ArtDispensingLog { get; set; }
        public string ArtRegister { get; set; }
        public string ArtTreatment { get; set; }
        public double? ArtTotal { get; set; }
        public double? ArtSparsTotal { get; set; }
        public string StockCard { get; set; }
        public string PhysicalCount { get; set; }
        public string StockCardFill { get; set; }
        public string UpdatingStockCard { get; set; }
        public string StockBookUse { get; set; }
        public string Amc { get; set; }
        public double? StockTotal { get; set; }
        public double? StockSparsTotal { get; set; }
        public string RequisitionSystem { get; set; }
        public string Supplier { get; set; }
        public string FacilityStore { get; set; }
        public string IssuedToPatients { get; set; }
        public double? TraceabilityTotal { get; set; }
        public double? TraceabilitySparsTotal { get; set; }
        public string ReportAvailability { get; set; }
        public string OrderAccuracy { get; set; }
        public string PatientReport { get; set; }
        public string TestKits { get; set; }
        public double? OrderTotal { get; set; }
        public double? OrderSparsTotal { get; set; }
        public string Cleanliness { get; set; }
        public string StorageSystem { get; set; }
        public string StorageCondition { get; set; }
        public string StoragePractice { get; set; }
        public double? StoreTotal { get; set; }
        public double? StoreSparsTotal { get; set; }
        public string FefoUse { get; set; }
        public string ExpiryPresence { get; set; }
        public string TackingTools { get; set; }
        public double? ExpiryTotal { get; set; }
        public double? ExpirySparsTotal { get; set; }
        public double? FinalTotal { get; set; }
        public double? FinalSparsTotal { get; set; }
        public string Score { get; set; }
        public string SparsScore { get; set; }
    }
}
