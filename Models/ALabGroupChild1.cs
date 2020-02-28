using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ALabGroupChild1
    {
        public ALabGroupChild1()
        {
            ALabGroupChild2 = new HashSet<ALabGroupChild2>();
            ALabItem = new HashSet<ALabItem>();
        }

        public int GroupCode { get; set; }
        public double GroupChild1 { get; set; }
        public string Child1Description { get; set; }

        public virtual ALabGroup1 GroupCodeNavigation { get; set; }
        public virtual ICollection<ALabGroupChild2> ALabGroupChild2 { get; set; }
        public virtual ICollection<ALabItem> ALabItem { get; set; }
    }
}
