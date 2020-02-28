using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssViewGuidQuestion
    {
        public int GuidId { get; set; }
        public int ModuleId { get; set; }
        public string ModuleDescription { get; set; }
        public int SectorId { get; set; }
        public string SectorDescription { get; set; }
        public string Question { get; set; }
    }
}
