using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewSsmtCrystalStockCardsBase
    {
        public string CategoryDesc { get; set; }
        public DateTime DateVisit { get; set; }
        public int? BYear { get; set; }
        public int? BMonth { get; set; }
        public int? StockCardCount { get; set; }
        public int? ProductCategoryCount { get; set; }
        public int? Denominator { get; set; }
        public int FacilityId { get; set; }
        public string MyCode { get; set; }
        public int CategoryCode { get; set; }
    }
}
