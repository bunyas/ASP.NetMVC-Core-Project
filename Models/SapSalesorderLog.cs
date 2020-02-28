using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SapSalesorderLog
    {
        public int Id { get; set; }
        public string Docnum { get; set; }
        public DateTime? Date { get; set; }
        public string Status { get; set; }
        public string OrderType { get; set; }
    }
}
