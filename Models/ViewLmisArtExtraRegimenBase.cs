using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisArtExtraRegimenBase
    {
        public short RegimenCode { get; set; }
        public string RegimenDesc { get; set; }
        public bool? StandardRegimen { get; set; }
        public short RegimenCategoryCode { get; set; }
        public string RegimenCategoryDesc { get; set; }
        public int RegimenClassificationCode { get; set; }
        public string RegimenClassificationDesc { get; set; }
    }
}
