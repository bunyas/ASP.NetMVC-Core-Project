using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AVenue
    {
        public AVenue()
        {
            AVenueList = new HashSet<AVenueList>();
        }

        public int Id { get; set; }
        public string VenueName { get; set; }
        public int? ResourceId { get; set; }
        public string Color { get; set; }

        public virtual ICollection<AVenueList> AVenueList { get; set; }
    }
}
