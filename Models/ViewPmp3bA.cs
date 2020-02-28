using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewPmp3bA
    {
        public string CopYear { get; set; }
        public string Period { get; set; }
        public string ProcurementRefNo { get; set; }
        public string ProductDescription { get; set; }
        public string Supplier { get; set; }
        public int? QtyOrdered { get; set; }
        public int? QtyGoodsReceived { get; set; }
        public string ScheduleStatus { get; set; }
        public DateTime? RescheduledDates { get; set; }
        public DateTime? DateReceiptAtTheAirport { get; set; }
        public string PurchaseOrdersFilledCorrectly { get; set; }
        public string OnTime { get; set; }
        public string ScheduledShipments { get; set; }
        public int? OutstandingQuantities { get; set; }
        public string ShipmentStatusPerPpDate { get; set; }
        public int? VarianceFromPpDueDate { get; set; }
        public string ShipmentStatusMaulSupplierDate { get; set; }
        public int? VarianceMaulSupplierAgreedDate { get; set; }
        public string Comments { get; set; }
        public int? Expr1 { get; set; }
        public string BiAnnual { get; set; }
    }
}
