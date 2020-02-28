using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcTrackerAwardPfi
    {
        public ProcTrackerAwardPfi()
        {
            ProcTrackerCi = new HashSet<ProcTrackerCi>();
        }

        public int AwardId { get; set; }
        public string ReferenceNo { get; set; }
        public int? Supplier { get; set; }
        public int? Product { get; set; }
        public string ProductStrength { get; set; }
        public short? ProductBasicUnit { get; set; }
        public int? ProductPackSize { get; set; }
        public int? ProductType { get; set; }
        public bool? ProductNtgApproved { get; set; }
        public bool? ProductWhoFdaApproved { get; set; }
        public bool? ConsistentNationalProcurementPlan { get; set; }
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

        public virtual ProcProductType ProductTypeNavigation { get; set; }
        public virtual ProcTracker ReferenceNoNavigation { get; set; }
        public virtual ICollection<ProcTrackerCi> ProcTrackerCi { get; set; }
    }
}
