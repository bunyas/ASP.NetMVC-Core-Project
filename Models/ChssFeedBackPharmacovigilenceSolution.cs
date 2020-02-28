using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssFeedBackPharmacovigilenceSolution
    {
        public DateTime DateOfVisit { get; set; }
        public int FacilityCode { get; set; }
        public int GuidId { get; set; }
        public string Result { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual ChssQuestionGuid Guid { get; set; }
    }
}
