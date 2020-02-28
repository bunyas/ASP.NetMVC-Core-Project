using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssViewQuestionClassification
    {
        public int CategoryCode { get; set; }
        public string CategoryDesc { get; set; }
        public int? GuidId { get; set; }
        public string Question { get; set; }
        public int ClassificationCode { get; set; }
        public int SectorId { get; set; }
    }
}
