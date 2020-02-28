using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcBudget
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CategoryCode { get; set; }
        public double? PatientNumbersOrTests { get; set; }
        public double? Fob { get; set; }
        public double? Psm { get; set; }
        public double? Total { get; set; }

        public virtual AProductCategory CategoryCodeNavigation { get; set; }
    }
}
