using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssEquipmentVerification
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int EquipId { get; set; }
        public string SerialNo { get; set; }
        public int? Quantity { get; set; }
        public string EngravingCode { get; set; }
        public string LocationAtHf { get; set; }
        public int? ItemFunctional { get; set; }
        public string Status { get; set; }
        public string ActionPoint { get; set; }
        public string Timeline { get; set; }

        public virtual ChssEquipment Equip { get; set; }
        public virtual AFacilities FacilityCodeNavigation { get; set; }
    }
}
