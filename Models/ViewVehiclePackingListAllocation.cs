using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewVehiclePackingListAllocation
    {
        public int FacilityCode { get; set; }
        public int DriverVehicleCode { get; set; }
        public string Facility { get; set; }
        public DateTime StartDateOrderForm { get; set; }
        public DateTime EndDateOrderForm { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public int? DeliveryZoneCode { get; set; }
    }
}
