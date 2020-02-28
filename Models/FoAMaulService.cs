using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoAMaulService
    {
        public FoAMaulService()
        {
            FoClientFeedback = new HashSet<FoClientFeedback>();
        }

        public int Id { get; set; }
        public string ServiceLevel { get; set; }

        public virtual ICollection<FoClientFeedback> FoClientFeedback { get; set; }
    }
}
