using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoContactTitle
    {
        public FoContactTitle()
        {
            FoClientFeedback = new HashSet<FoClientFeedback>();
            FoContactPerson = new HashSet<FoContactPerson>();
            FoSsmtInterviewedPersonnel = new HashSet<FoSsmtInterviewedPersonnel>();
        }

        public int TitleCode { get; set; }
        public string TitleDesc { get; set; }

        public virtual ICollection<FoClientFeedback> FoClientFeedback { get; set; }
        public virtual ICollection<FoContactPerson> FoContactPerson { get; set; }
        public virtual ICollection<FoSsmtInterviewedPersonnel> FoSsmtInterviewedPersonnel { get; set; }
    }
}
