using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssFeedBackReportView
    {
        public int FacilityCode { get; set; }
        public string Facility { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int ModuleId { get; set; }
        public string ModuleDescription { get; set; }
        public int SectorId { get; set; }
        public string SectorDescription { get; set; }
        public string Comment { get; set; }
        public string Recommendation { get; set; }
        public string ActionPlan { get; set; }
        public string TimeLine { get; set; }
        public string ResponsiblePerson { get; set; }
    }
}
