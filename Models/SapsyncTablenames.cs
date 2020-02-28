using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SapsyncTablenames
    {
        public int Id { get; set; }
        public string HeaderTable { get; set; }
        public string LineTable { get; set; }
        public bool Status { get; set; }
        public string OrderType { get; set; }
    }
}
