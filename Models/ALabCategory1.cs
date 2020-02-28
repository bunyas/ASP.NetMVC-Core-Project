using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ALabCategory1
    {
        public ALabCategory1()
        {
            ALabCategory2 = new HashSet<ALabCategory2>();
        }

        public int LabCat1Code { get; set; }
        public string LabCat1Desc { get; set; }

        public virtual ICollection<ALabCategory2> ALabCategory2 { get; set; }
    }
}
