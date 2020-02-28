using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssMEquipmentVerification
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public string ZoneDescription { get; set; }
        public string Cdcregion { get; set; }
        public string DistrictName { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public string LevelOfCare { get; set; }
        public string Scto { get; set; }
        public string CatDesc { get; set; }
        public int EquipId { get; set; }
        public string EquipDesc { get; set; }
        public string SerialNo { get; set; }
        public int? Quantity { get; set; }
        public string EngravingCode { get; set; }
        public string LocationAtHf { get; set; }
        public string ItemFunctional { get; set; }
        public string Status { get; set; }
        public string ActionPoint { get; set; }
        public string Timeline { get; set; }
    }
}
