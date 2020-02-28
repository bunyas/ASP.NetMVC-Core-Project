using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ApprovedFacilityOrders
    {
        public ApprovedFacilityOrders()
        {
            VehiclePackingListAllocation = new HashSet<VehiclePackingListAllocation>();
        }

        public int FacilityCode { get; set; }
        public DateTime StartDateOrderForm { get; set; }
        public DateTime EndDateOrderForm { get; set; }
        public DateTime? DatePhysicalCountForm { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }
        public string IssuedBy { get; set; }
        public DateTime? IssuedDate { get; set; }

        public virtual UserAccount ApprovedByNavigation { get; set; }
        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual UserAccount IssuedByNavigation { get; set; }
        public virtual PhysicalCountHeader PhysicalCountHeader { get; set; }
        public virtual ICollection<VehiclePackingListAllocation> VehiclePackingListAllocation { get; set; }
    }
}
