using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoSsmtStoragePractice
    {
        public FoSsmtStoragePractice()
        {
            FoSsmtIndicator = new HashSet<FoSsmtIndicator>();
        }

        public int StoragePracticeCode { get; set; }
        public string StoragePracticeDesc { get; set; }

        public virtual ICollection<FoSsmtIndicator> FoSsmtIndicator { get; set; }
    }
}
