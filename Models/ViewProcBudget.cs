using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewProcBudget
    {
        public int CategoryCode { get; set; }
        public int? PatientNumbersOrTests { get; set; }
        public int? Fob { get; set; }
        public int? Psm { get; set; }
        public int? Total { get; set; }
    }
}
