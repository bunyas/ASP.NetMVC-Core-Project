using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ALabGroupChild2
    {
        public ALabGroupChild2()
        {
            ALabItem = new HashSet<ALabItem>();
        }

        public int GroupCode { get; set; }
        public double GroupChild1 { get; set; }
        public double GroupChild2 { get; set; }
        public string Child2Description { get; set; }

        public virtual ALabGroupChild1 GroupC { get; set; }
        public virtual ICollection<ALabItem> ALabItem { get; set; }
    }
}
