using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssTraceabilitySupplierToFacilityStore
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int ProductCode { get; set; }
        public int? RecentDeliveryNoteQuantity { get; set; }
        public string RecentDeliveryNoteBatch { get; set; }
        public int? RespondingGoodsReceivedNoteQuantity { get; set; }
        public string RespondingGoodsReceivedBatch { get; set; }
        public int? ReceivedStockCardQuantity { get; set; }
        public string ReceivedStockCardNoteBatch { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual AProduct ProductCodeNavigation { get; set; }
    }
}
