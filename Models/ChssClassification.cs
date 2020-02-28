using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssClassification
    {
        public ChssClassification()
        {
            ChssExpiryFefoUse = new HashSet<ChssExpiryFefoUse>();
            ChssExpiryPresence = new HashSet<ChssExpiryPresence>();
            ChssExpiryTrackingTools = new HashSet<ChssExpiryTrackingTools>();
        }

        public int ClassificationCode { get; set; }
        public int? CategoryCode { get; set; }
        public int? GuidId { get; set; }

        public virtual ChssCategory CategoryCodeNavigation { get; set; }
        public virtual ChssQuestionGuid Guid { get; set; }
        public virtual ICollection<ChssExpiryFefoUse> ChssExpiryFefoUse { get; set; }
        public virtual ICollection<ChssExpiryPresence> ChssExpiryPresence { get; set; }
        public virtual ICollection<ChssExpiryTrackingTools> ChssExpiryTrackingTools { get; set; }
    }
}
