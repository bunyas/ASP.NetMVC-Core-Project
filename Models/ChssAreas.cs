using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssAreas
    {
        public ChssAreas()
        {
            ChssAreasVisited = new HashSet<ChssAreasVisited>();
        }

        public int AreaCode { get; set; }
        public string AreaDesc { get; set; }

        public virtual ICollection<ChssAreasVisited> ChssAreasVisited { get; set; }
    }
}
