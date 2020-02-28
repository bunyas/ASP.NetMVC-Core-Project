using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssHivOrderView
    {
        public int? FacilityCode { get; set; }
        public string Facility { get; set; }
        public string FacilityTypeId { get; set; }
        public string FacilityType { get; set; }
        public int ItemCode { get; set; }
        public string ProductDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
