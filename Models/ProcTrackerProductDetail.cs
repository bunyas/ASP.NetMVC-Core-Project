using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcTrackerProductDetail
    {
        public string PurchaseOrderNo { get; set; }
        public int SupplierId { get; set; }
        public DateTime OrderDueDate { get; set; }
        public int ProductCode { get; set; }
        public string ProductStrength { get; set; }
        public short? ProductBasicUnit { get; set; }
        public int? ProductPackSize { get; set; }
        public int? ExpectedShipment { get; set; }
        public double? ScmsPrice { get; set; }
        public double? FobPrice { get; set; }
        public double? FobPriceTotal { get; set; }
        public double? PriceVariance { get; set; }
        public double? ProductCostComparedToInternationalCostAnalysis { get; set; }
        public double? CifPrice { get; set; }
        public double? InsuranceFreight { get; set; }
        public double? BudgetedValue { get; set; }
        public double? TotalOrderValue { get; set; }
        public int? ProcurementPlanQuantity { get; set; }
        public double? PercentageScheduledShipmentsThatMatchProcurementPlanBudget { get; set; }
        public int? NormalOrEmergencyProcurement { get; set; }
        public bool? OnTimePerformanceOfInboundCommodityShipments { get; set; }
        public int? QuantityRecievedMaul { get; set; }
        public int? OutstandingQuantity { get; set; }
        public DateTime? DateArrivalEntebbe { get; set; }
        public DateTime? DateClearedCustoms { get; set; }
        public double? CifPriceTotal { get; set; }
        public int? OrderStatus { get; set; }
        public int? ProductTypeCode { get; set; }
        public DateTime? DateIssueAward { get; set; }
        public DateTime? DateAcceptanceAwardSupplier { get; set; }
        public DateTime? NewProposalDueDate { get; set; }
        public double? CifAwardDifferenceCifPfi { get; set; }
        public DateTime? DateSupplierSentShippingDocumentsToMaul { get; set; }
        public DateTime? DateRecieptClearingAgent { get; set; }
        public int? FitForPurpose { get; set; }
        public int? Vendor { get; set; }
        public int? Manufacturer { get; set; }
        public int? CountryOfOrigin { get; set; }
        public int? Completion { get; set; }

        public virtual ProcTrackerOrderStatus OrderStatusNavigation { get; set; }
        public virtual ProcTrackerOrder ProcTrackerOrder { get; set; }
        public virtual ADrugBasicUnit ProductBasicUnitNavigation { get; set; }
    }
}
