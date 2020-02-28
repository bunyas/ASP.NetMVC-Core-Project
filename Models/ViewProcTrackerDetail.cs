using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewProcTrackerDetail
    {
        public string PurchaseOrderNo { get; set; }
        public int? OrderOrgan { get; set; }
        public int? OrderType { get; set; }
        public int? OrderYear { get; set; }
        public int? OrderQuater { get; set; }
        public int? OrderCategory { get; set; }
        public string OrderNo { get; set; }
        public int? Addendum { get; set; }
        public string TaskOrderNo { get; set; }
        public int? PurcNoOrderType { get; set; }
        public int? NormalEmergencyProcurement { get; set; }
        public string ReferenceNo { get; set; }
        public int? Supplier { get; set; }
        public int? Product { get; set; }
        public double? ProcurementQuantity { get; set; }
        public DateTime? AwardDateIssueAward { get; set; }
        public double? AwardQuantityOrdered { get; set; }
        public DateTime? AwardExpectedDateDelivery { get; set; }
        public double? AwardFobPrice { get; set; }
        public double? AwardScmsPrice { get; set; }
        public double? AwardCifCipDdpPrice { get; set; }
        public DateTime? AwardNewDueDate { get; set; }
        public double? AwardTotalFobPrice { get; set; }
        public double? AwardUnitFobScmsPrice { get; set; }
        public double? AwardTotalCifCipDdpPrice { get; set; }
        public DateTime? AwardDateAcceptanceAward { get; set; }
        public string PfiNo { get; set; }
        public DateTime? PfiDate { get; set; }
        public DateTime? PfiDateSubmission { get; set; }
        public double? PfiTotalFob { get; set; }
        public double? PfiFobVariance { get; set; }
        public double? PfiTotalCif { get; set; }
        public double? PfiCifVariance { get; set; }
        public double? PfiInsuranceFrieght { get; set; }
        public DateTime? PfiDateToNda { get; set; }
        public DateTime? PfiVerifiedNda { get; set; }
        public DateTime? PfiVerifiedSupplier { get; set; }
        public DateTime? DateShippingDocumentsSentMaul { get; set; }
        public string InvoiceNo { get; set; }
        public double? InvoiceValue { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? DateArrivalEntryPort { get; set; }
        public DateTime? DateClearedEntryPort { get; set; }
        public DateTime? DateDeliveredWarehouse { get; set; }
        public double? QuantityRecievedMaul { get; set; }
        public double? QuantityOutstanding { get; set; }
        public int? FitForPurpose { get; set; }
        public int? QualityIssue { get; set; }
        public int? OrderStatus { get; set; }
        public int? Vendor { get; set; }
        public int? Manufacturer { get; set; }
        public int? CountryOrigin { get; set; }
        public string GrnNo { get; set; }
        public DateTime? GrnDate { get; set; }
        public double? GrnQuantity { get; set; }
        public DateTime? GrnDateReceiptWarehouse { get; set; }
        public string QualityIssueDesc { get; set; }
        public int AwardId { get; set; }
        public int? CommercialInvoiceId { get; set; }
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
    }
}
