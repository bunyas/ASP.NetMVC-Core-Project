using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoSsmtInidcatorGuideline
    {
        public int IndicatorGuidelineCode { get; set; }
        public int? IndicatorCode { get; set; }
        public string IndicatorGuidelineDesc { get; set; }

        public virtual FoSsmtIndicator IndicatorCodeNavigation { get; set; }
    }
}
