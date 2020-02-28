using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoSsmtStockManagement
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int ProductCode { get; set; }
        public int? UnitPack { get; set; }
        public bool? ItemAvialable { get; set; }
        public bool? StockCardAvialable { get; set; }
        public bool? StockKeptOnShelves { get; set; }
        public bool? PhysicalCountDoneMonthly { get; set; }
        public bool? CardFilledOutCorrectly { get; set; }
        public double? BalanceStockCard { get; set; }
        public double? CountDrugsStockRecord { get; set; }
        public bool? BalanceStockCardEqualBalancePhysicalCount { get; set; }
        public int? RecordAmc { get; set; }
        public double? CalculatedAmc { get; set; }
        public int? DaysOutOfStockLast3Months { get; set; }
        public double? HighestBalanceOnHandLast6Months { get; set; }

        public virtual FoSsmtFacility FoSsmtFacility { get; set; }
    }
}
