using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssExpiryTrackingTools
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int GuidId { get; set; }
        public int ClassificationCode { get; set; }
        public int? Result { get; set; }

        public virtual ChssClassification ClassificationCodeNavigation { get; set; }
        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual ChssQuestionGuid Guid { get; set; }
    }
}
