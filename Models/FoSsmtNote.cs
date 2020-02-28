using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoSsmtNote
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int StoragePracticeCode { get; set; }
        public string Note { get; set; }
    }
}
