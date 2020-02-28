using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoSsmtIndicator
    {
        public FoSsmtIndicator()
        {
            FoSsmtIndicatorTracker = new HashSet<FoSsmtIndicatorTracker>();
            FoSsmtInidcatorGuideline = new HashSet<FoSsmtInidcatorGuideline>();
        }

        public int IndicatorCode { get; set; }
        public int StoragePracticeCode { get; set; }
        public string IndicatorDesc { get; set; }

        public virtual FoSsmtStoragePractice StoragePracticeCodeNavigation { get; set; }
        public virtual ICollection<FoSsmtIndicatorTracker> FoSsmtIndicatorTracker { get; set; }
        public virtual ICollection<FoSsmtInidcatorGuideline> FoSsmtInidcatorGuideline { get; set; }
    }
}
