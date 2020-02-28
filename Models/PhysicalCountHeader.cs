using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class PhysicalCountHeader
    {
        public PhysicalCountHeader()
        {
            ApprovedFacilityOrders = new HashSet<ApprovedFacilityOrders>();
            PhysicalCountDetails = new HashSet<PhysicalCountDetails>();
        }

        public int FacilityCode { get; set; }
        public DateTime DateRecorded { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }

        public virtual UserAccount AddedByNavigation { get; set; }
        public virtual UserAccount EditedByNavigation { get; set; }
        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual ICollection<ApprovedFacilityOrders> ApprovedFacilityOrders { get; set; }
        public virtual ICollection<PhysicalCountDetails> PhysicalCountDetails { get; set; }
    }
}
