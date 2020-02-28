using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoContactPerson
    {
        public int CpCode { get; set; }
        public string CpName { get; set; }
        public int? CpTitle { get; set; }
        public int? CpFacility { get; set; }
        public int? CpDistrict { get; set; }
        public int? CpCategory { get; set; }
        public int? CpIp { get; set; }
        public int? CpSupplierCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public string UserId { get; set; }
        public bool? IsActive { get; set; }

        public virtual FoContactCategory CpCategoryNavigation { get; set; }
        public virtual AFacilities CpFacilityNavigation { get; set; }
        public virtual AImplimentingPartners CpIpNavigation { get; set; }
        public virtual ASupplier CpSupplierCodeNavigation { get; set; }
        public virtual FoContactTitle CpTitleNavigation { get; set; }
        public virtual FoContactEmail FoContactEmail { get; set; }
        public virtual FoContactTelephone FoContactTelephone { get; set; }
    }
}
