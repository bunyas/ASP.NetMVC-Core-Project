using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistPermitCategory
    {
        public DistPermitCategory()
        {
            DistOperatorPermit = new HashSet<DistOperatorPermit>();
            DistOperatorPersonal = new HashSet<DistOperatorPersonal>();
        }

        public int PermitTypeCode { get; set; }
        public string PermitDescription { get; set; }

        public virtual ICollection<DistOperatorPermit> DistOperatorPermit { get; set; }
        public virtual ICollection<DistOperatorPersonal> DistOperatorPersonal { get; set; }
    }
}
