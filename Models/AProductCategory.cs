using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AProductCategory
    {
        public AProductCategory()
        {
            AProduct = new HashSet<AProduct>();
            LmisExpectedReport = new HashSet<LmisExpectedReport>();
            OrderLabCustomHeader = new HashSet<OrderLabCustomHeader>();
            OrderMaultHeader = new HashSet<OrderMaultHeader>();
            ProcBudget = new HashSet<ProcBudget>();
            ProcPrequalifiedSupplier = new HashSet<ProcPrequalifiedSupplier>();
            SapEmergencySiteOrderHeader = new HashSet<SapEmergencySiteOrderHeader>();
        }

        public int CategoryCode { get; set; }
        public string CategoryDesc { get; set; }

        public virtual ICollection<AProduct> AProduct { get; set; }
        public virtual ICollection<LmisExpectedReport> LmisExpectedReport { get; set; }
        public virtual ICollection<OrderLabCustomHeader> OrderLabCustomHeader { get; set; }
        public virtual ICollection<OrderMaultHeader> OrderMaultHeader { get; set; }
        public virtual ICollection<ProcBudget> ProcBudget { get; set; }
        public virtual ICollection<ProcPrequalifiedSupplier> ProcPrequalifiedSupplier { get; set; }
        public virtual ICollection<SapEmergencySiteOrderHeader> SapEmergencySiteOrderHeader { get; set; }
    }
}
