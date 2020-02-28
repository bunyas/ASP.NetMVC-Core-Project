using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewXaRegimen
    {
        public short RegimenCode { get; set; }
        public string RegimenDesc { get; set; }
        public string ExtraInfo { get; set; }
        public string DrugCombination { get; set; }
        public short? RegimenCategoryCode { get; set; }
        public bool? StandardRegimen { get; set; }
        public string RegimenCategoryDesc { get; set; }
        public int RegimenClassificationCode { get; set; }
        public string RegimenClassificationDesc { get; set; }
    }
}
