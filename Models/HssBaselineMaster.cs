using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class HssBaselineMaster
    {
        public HssBaselineMaster()
        {
            HssBaselineHfService = new HashSet<HssBaselineHfService>();
            HssBaselineLaboratory = new HashSet<HssBaselineLaboratory>();
            HssBaselinePharmacy = new HashSet<HssBaselinePharmacy>();
            HssBaselineToolsReview = new HashSet<HssBaselineToolsReview>();
        }

        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public bool? RecordStatus { get; set; }

        public virtual ICollection<HssBaselineHfService> HssBaselineHfService { get; set; }
        public virtual ICollection<HssBaselineLaboratory> HssBaselineLaboratory { get; set; }
        public virtual ICollection<HssBaselinePharmacy> HssBaselinePharmacy { get; set; }
        public virtual ICollection<HssBaselineToolsReview> HssBaselineToolsReview { get; set; }
    }
}
