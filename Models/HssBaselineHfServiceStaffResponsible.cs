using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineHfServiceStaffResponsible
    {
        public int FacilityCode { get; set; }
        public DateTime InterviewDate { get; set; }
        public int HfService2Code { get; set; }
        public int? PlacesOrders { get; set; }
        public int? CoordinateDeliveryTransport { get; set; }
        public int? RecieveSupplies { get; set; }
        public int? ManageStock { get; set; }
        public int? Supervises { get; set; }
    }
}
