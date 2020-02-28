using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssRegimenView
    {
        public int? RegimenClassification { get; set; }
        public string RegimenClassificationDesc { get; set; }
        public short? RegimenCategoryCode { get; set; }
        public string RegimenCategoryDesc { get; set; }
        public short RegimenCode { get; set; }
        public string RegimenDesc { get; set; }
    }
}
