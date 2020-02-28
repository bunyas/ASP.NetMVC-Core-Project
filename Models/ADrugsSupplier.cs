using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ADrugsSupplier
    {
        public short SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Addres { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public short? Ownership { get; set; }
    }
}
