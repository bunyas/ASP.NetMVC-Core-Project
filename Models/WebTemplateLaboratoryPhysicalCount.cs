using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class WebTemplateLaboratoryPhysicalCount
    {
        public int ProductOrder { get; set; }
        public int? ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string BasicUnit { get; set; }
        public string Form { get; set; }
        public int? QuantityDispensary { get; set; }
        public int? QuantityStore { get; set; }
        public string BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? Total { get; set; }
        public DateTime? DateOfPhysicalCount { get; set; }
        public int? FacilityCode { get; set; }
        public string Comment { get; set; }
        public int? ProductCategory { get; set; }
    }
}
