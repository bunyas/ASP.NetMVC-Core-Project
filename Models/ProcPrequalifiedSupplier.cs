using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcPrequalifiedSupplier
    {
        public int SupplierCode { get; set; }
        public DateTime StartOfPeriod { get; set; }
        public DateTime EndOfPeriod { get; set; }
        public int ProductCategory { get; set; }

        public virtual AProductCategory ProductCategoryNavigation { get; set; }
        public virtual ASupplier SupplierCodeNavigation { get; set; }
    }
}
