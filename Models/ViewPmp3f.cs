using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewPmp3f
    {
        public string CopYear { get; set; }
        public string Period { get; set; }
        public int? ProductId { get; set; }
        public string ProductDescription { get; set; }
        public string ProcurementRefNo { get; set; }
        public string Supplier { get; set; }
        public int? QtyOrdered { get; set; }
        public DateTime? DueDatePerProcurementPlan { get; set; }
        public DateTime? DateEmailSentToSupplier { get; set; }
        public DateTime? DateSupplierResponseToEmail { get; set; }
        public string ScheduleStatus { get; set; }
        public DateTime? RescheduledDates { get; set; }
        public int? QtyGoodsReceived { get; set; }
        public string PurchaseOrdersFilled { get; set; }
        public int? Airport { get; set; }
        public string OnTime { get; set; }
        public string ScheduledShipments { get; set; }
        public int? OutstandingQuantities { get; set; }
        public DateTime? DateGoodsReceiptAtAirport { get; set; }
        public DateTime? DateGoodsReceiptMaulWarehouse { get; set; }
        public string ShipmentStatusPerPpDate { get; set; }
        public int? VariancePpDate { get; set; }
        public string ShipmentStatusMaulSupplierDate { get; set; }
        public int? VarianceMaulSupplierDueDate { get; set; }
        public string Comments { get; set; }
        public string BiAnnual { get; set; }
    }
}
