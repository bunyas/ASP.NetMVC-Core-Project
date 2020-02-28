using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SsmtStockManagementPractices
    {
        public int FacilityId { get; set; }
        public DateTime DateVisit { get; set; }
        public int ProductCode { get; set; }
        public int? ItemAvialable { get; set; }
        public int? StockCardAvialable { get; set; }
        public int? StockCardWithShelfItems { get; set; }
        public int? MonthlyPhysicalCount { get; set; }
        public int? CardFilledCorrectly { get; set; }
        public double? BalanceStockCard { get; set; }
        public double? BalancePhysicalCount { get; set; }
        public int? BalanceScEqualPc { get; set; }
        public int? AmcOnStockCard { get; set; }
        public double? Amc { get; set; }
        public double? CalculatedAmc { get; set; }
        public int? AmcsEqual { get; set; }
        public double? StockOutLast3Months { get; set; }
        public double? HighestBalanceLast6Months { get; set; }
        public int? MaxScore { get; set; }
        public int? Score { get; set; }

        public virtual AProduct ProductCodeNavigation { get; set; }
        public virtual SsmtFacility SsmtFacility { get; set; }
    }
}
