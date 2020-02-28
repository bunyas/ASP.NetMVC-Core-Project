using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewSapXVlrEmergency
    {
        public bool? MiCheck { get; set; }
        public int? LevelOfCare { get; set; }
        public string Facility { get; set; }
        public int ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string ProductSapCode { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public string Packsize { get; set; }
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ProductCode1 { get; set; }
        public DateTime DatePrepared { get; set; }
        public double? QuantityAllocated { get; set; }
        public string FacilitySapCode { get; set; }
        public bool? RecordStatus { get; set; }
    }
}
