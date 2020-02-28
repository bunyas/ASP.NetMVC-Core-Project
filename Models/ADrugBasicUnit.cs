using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ADrugBasicUnit
    {
        public ADrugBasicUnit()
        {
            ADrugFormulation = new HashSet<ADrugFormulation>();
            AProduct = new HashSet<AProduct>();
            ProcTrackerProductDetail = new HashSet<ProcTrackerProductDetail>();
        }

        public short ItemCode { get; set; }
        public string ItemForm { get; set; }

        public virtual ICollection<ADrugFormulation> ADrugFormulation { get; set; }
        public virtual ICollection<AProduct> AProduct { get; set; }
        public virtual ICollection<ProcTrackerProductDetail> ProcTrackerProductDetail { get; set; }
    }
}
