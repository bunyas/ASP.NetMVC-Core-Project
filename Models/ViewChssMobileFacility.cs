using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewChssMobileFacility
    {
        public int FacilityCode { get; set; }
        public string Facility { get; set; }
        public string Cdcregion { get; set; }
        public string DistrictName { get; set; }
        public string LevelOfCare { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public bool? SupportedByMaul { get; set; }
        public bool? IsAccredited { get; set; }
        public string FacilityInchargeName { get; set; }
        public string FacilityInchargeContact { get; set; }
        public string ArtInchargeName { get; set; }
        public string ArtInchargeContact { get; set; }
        public string MmsName { get; set; }
        public string MmsContact { get; set; }
        public string PharmaconvigilenceName { get; set; }
        public string PharmaconvigilenceContact { get; set; }
        public int? SupervisionNo { get; set; }
    }
}
