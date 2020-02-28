using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewFoQiCloseOutCertificate
    {
        public int Id { get; set; }
        public int ERegComplaintCode { get; set; }
        public int ProductCode { get; set; }
        public string BatchNo { get; set; }
        public string ERegComplaintNo { get; set; }
        public string SummaryOfInvestigations { get; set; }
        public int? ReleaseInstruction { get; set; }
        public string OtherAttachment { get; set; }
        public int? WarehouseOfficer { get; set; }
        public DateTime? WarehouseDate { get; set; }
        public int? FinanceManager { get; set; }
        public DateTime? FinanceDate { get; set; }
        public int? DirectorTechnical { get; set; }
        public DateTime? DirectorTechnicalDate { get; set; }
        public int? ExecutiveDirector { get; set; }
        public DateTime? ExecutiveDirectorDate { get; set; }
        public int? ComplaintReport { get; set; }
        public string ComplaintReportComment { get; set; }
        public int? NotificationPac { get; set; }
        public string NotificationPacComment { get; set; }
        public int? NotificationVendor { get; set; }
        public string NotificationVendorComment { get; set; }
        public int? ProductCoas { get; set; }
        public string ProductCoasComment { get; set; }
        public int? Capa { get; set; }
        public string CapaComment { get; set; }
        public int? ReturnedNote { get; set; }
        public string ReturnedNoteComment { get; set; }
        public int? CreditNote { get; set; }
        public string CreditNoteComment { get; set; }
        public int? Reconciliation { get; set; }
        public string ReconciliationComment { get; set; }
        public int? NdaNotification { get; set; }
        public string NdaNotificationComment { get; set; }
    }
}
