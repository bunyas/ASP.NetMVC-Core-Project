using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SsmtStockManagementToolsLab
    {
        public int FacilityId { get; set; }
        public DateTime DateVisit { get; set; }
        public int ProductCategoryCode { get; set; }
        public int? ItemAvialable { get; set; }
        public DateTime? DateIssueVourcher { get; set; }
        public double? QuantityIssuedVourcher { get; set; }
        public DateTime? DateIssueStockCard { get; set; }
        public double? QuantityIssueStockCard { get; set; }
        public int? DateTally { get; set; }
        public int? QuantitiesTally { get; set; }
        public int? MaxScore { get; set; }
        public int? Score { get; set; }

        public virtual AProductLabCategory ProductCategoryCodeNavigation { get; set; }
        public virtual SsmtFacility SsmtFacility { get; set; }
    }
}
