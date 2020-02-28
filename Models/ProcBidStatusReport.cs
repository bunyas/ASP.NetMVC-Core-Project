using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcBidStatusReport
    {
        public string ProcurementReferenceNumber { get; set; }
        public string ProcurementSubject { get; set; }
        public int? Category { get; set; }
        public int? Quantity { get; set; }
        public double? BudgetUsd { get; set; }
        public int? ProcurementMethod { get; set; }
        public DateTime? DatePreparationOfSpecificationsTorSowRfq { get; set; }
        public DateTime? DatePresentationRfqRfpToPac { get; set; }
        public DateTime? DateOfInvitation { get; set; }
        public int? NumberOfInvitedProviders { get; set; }
        public int? NumberOfSuppliersThatConfirmedReciept { get; set; }
        public string ActionDescription { get; set; }
        public DateTime? StartDateRequestClarificationFromSuppliers { get; set; }
        public DateTime? EndDateRequestClarificationFromSuppliers { get; set; }
        public DateTime? StartDateResponseToClarificationFromMaul { get; set; }
        public DateTime? EndDateResponseToClarificationFromMaul { get; set; }
        public int? ClarificationsRecieved { get; set; }
        public int? ClarificationsAnswered { get; set; }
        public int? SuppliersThatSubmittedQuotationBeforeDeadline { get; set; }
        public DateTime? BidOpeningDate { get; set; }
        public DateTime? EvaluationCommencementDate { get; set; }
        public DateTime? DateRequestClarificationByMaul { get; set; }
        public DateTime? DateResponseToClarificationBySuppliers { get; set; }
        public DateTime? DateConfirmationByUserDepartment { get; set; }
        public DateTime? DateSubmissionOfEvaluationReportToPac { get; set; }
        public DateTime? DateSubmissionOfEvaluationReportToCdc { get; set; }
        public DateTime? DateResponseFromCdc { get; set; }
        public int? ResponseFromCdcd { get; set; }
        public string ResponseFromCdcdescription { get; set; }
        public DateTime? DateOfNegotiations { get; set; }
        public DateTime? DateNegotiationPresentationReportAwardedToPac { get; set; }
        public DateTime? DateOfDueDeligencePostQualification { get; set; }
        public DateTime? DateOfPacapprovalOfEvaluationReportAward { get; set; }
        public DateTime? DateOfIssueOfAward { get; set; }
        public double? ContractAmountUsd { get; set; }
        public bool? UnsuccessfulProvidersNotified { get; set; }
        public double? ContractBalanceUsd { get; set; }
        public double? ProcurementLeadTimeInDays { get; set; }
        public int? CotractManagementReportId { get; set; }
        public string CotractManagementReportDescription { get; set; }
        public int? CurrentStatus { get; set; }
        public string CurrentStatusDescription { get; set; }
        public int? NextAction { get; set; }

        public virtual ProcBidStatusCurrentStatus CurrentStatusNavigation { get; set; }
        public virtual ProcBidStatusAction NextActionNavigation { get; set; }
        public virtual ProcBidStatusReportProcurementMethod ProcurementMethodNavigation { get; set; }
        public virtual ProcBidStatusProcurementReferenceNumber ProcurementReferenceNumberNavigation { get; set; }
        public virtual ProcBidStatusCdcResponse ResponseFromCdcdNavigation { get; set; }
    }
}
