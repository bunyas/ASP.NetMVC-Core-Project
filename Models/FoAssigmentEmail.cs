using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoAssigmentEmail
    {
        public string ERegComplaintNo { get; set; }
        public int CpCode { get; set; }
        public int EmailLevel { get; set; }
        public DateTime? DateOfEmail { get; set; }
    }
}
