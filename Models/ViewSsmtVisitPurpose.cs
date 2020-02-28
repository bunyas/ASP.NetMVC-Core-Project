using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewSsmtVisitPurpose
    {
        public int VisitPurposeCode { get; set; }
        public string VisitPurposeDesc { get; set; }
        public bool? Visited { get; set; }
        public string Comments { get; set; }
    }
}
