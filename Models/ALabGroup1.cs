using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ALabGroup1
    {
        public ALabGroup1()
        {
            ALabGroupChild1 = new HashSet<ALabGroupChild1>();
            ALabItem = new HashSet<ALabItem>();
        }

        public int GroupCode { get; set; }
        public string GroupDescription { get; set; }

        public virtual ICollection<ALabGroupChild1> ALabGroupChild1 { get; set; }
        public virtual ICollection<ALabItem> ALabItem { get; set; }
    }
}
