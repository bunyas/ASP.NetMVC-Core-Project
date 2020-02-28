using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoSsmtFacility
    {
        public FoSsmtFacility()
        {
            FoSsmtAreaVisited = new HashSet<FoSsmtAreaVisited>();
            FoSsmtIndicatorTracker = new HashSet<FoSsmtIndicatorTracker>();
            FoSsmtInterviewedPersonnel = new HashSet<FoSsmtInterviewedPersonnel>();
            FoSsmtOrderingReporting = new HashSet<FoSsmtOrderingReporting>();
            FoSsmtStockManagement = new HashSet<FoSsmtStockManagement>();
            FoSsmtStockManagementScore = new HashSet<FoSsmtStockManagementScore>();
            FoSsmtSupervisor = new HashSet<FoSsmtSupervisor>();
        }

        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public DateTime? NextPlannedVisit { get; set; }

        public virtual ICollection<FoSsmtAreaVisited> FoSsmtAreaVisited { get; set; }
        public virtual ICollection<FoSsmtIndicatorTracker> FoSsmtIndicatorTracker { get; set; }
        public virtual ICollection<FoSsmtInterviewedPersonnel> FoSsmtInterviewedPersonnel { get; set; }
        public virtual ICollection<FoSsmtOrderingReporting> FoSsmtOrderingReporting { get; set; }
        public virtual ICollection<FoSsmtStockManagement> FoSsmtStockManagement { get; set; }
        public virtual ICollection<FoSsmtStockManagementScore> FoSsmtStockManagementScore { get; set; }
        public virtual ICollection<FoSsmtSupervisor> FoSsmtSupervisor { get; set; }
    }
}
