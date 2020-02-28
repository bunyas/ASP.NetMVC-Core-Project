using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssMFrostStockMovement
    {
        public int? FacilityCode { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public string DistrictName { get; set; }
        public string Cdcregion { get; set; }
        public string LevelOfCare { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public string Scto { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int ProductCode { get; set; }
        public string ProductSapCode { get; set; }
        public string ProductDescription { get; set; }
        public string Strength { get; set; }
        public string Packsize { get; set; }
        public string CategoryDesc { get; set; }
        public int? TopUpQuantity { get; set; }
        public string TopUpOption { get; set; }
        public string OrderFulfilmentStatus { get; set; }
    }
}
