using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ASupplier
    {
        public ASupplier()
        {
            FoContactPerson = new HashSet<FoContactPerson>();
            ProcPrequalifiedSupplier = new HashSet<ProcPrequalifiedSupplier>();
            ProcTask = new HashSet<ProcTask>();
        }

        public int SupplierCode { get; set; }
        public string SupplierDesc { get; set; }
        public int? CountryCode { get; set; }
        public int? Status { get; set; }
        public int? SupplierCategory { get; set; }

        public virtual ASupplierStatus StatusNavigation { get; set; }
        public virtual ICollection<FoContactPerson> FoContactPerson { get; set; }
        public virtual ICollection<ProcPrequalifiedSupplier> ProcPrequalifiedSupplier { get; set; }
        public virtual ICollection<ProcTask> ProcTask { get; set; }
    }
}
