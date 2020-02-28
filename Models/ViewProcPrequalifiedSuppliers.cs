using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewProcPrequalifiedSuppliers
    {
        public int SupplierCode { get; set; }
        public DateTime StartOfPeriod { get; set; }
        public DateTime EndOfPeriod { get; set; }
        public int ProductCategory { get; set; }
        public string SupplierDesc { get; set; }
        public int? CountryCode { get; set; }
    }
}
