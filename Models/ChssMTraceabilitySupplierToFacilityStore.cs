using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssMTraceabilitySupplierToFacilityStore
    {
        public int FacilityCode { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public int? DistrrictCode { get; set; }
        public string DistrictName { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public string ImplimentingPartnerDescription { get; set; }
        public string LevelDesc { get; set; }
        public int? CdcregionId { get; set; }
        public string Cdcregion { get; set; }
        public int? ComprehensiveImplimentingPartnerCode { get; set; }
        public string ComprehensiveImplimentingPartnerDescription { get; set; }
        public string Scto { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Packsize { get; set; }
        public string RecentDeliveryNoteQuantity { get; set; }
        public string RecentDeliveryNoteBatch { get; set; }
        public string RespondingGoodsReceivedNoteQuantity { get; set; }
        public string RespondingGoodsReceivedBatch { get; set; }
        public string ReceivedStockCardQuantity { get; set; }
        public string ReceivedStockCardNoteBatch { get; set; }
        public int BatchComp { get; set; }
        public int QuantityComp { get; set; }
    }
}
