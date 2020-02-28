using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class PmpDataCollectionFrequency
    {
        public PmpDataCollectionFrequency()
        {
            PmpPerformanceIndicator = new HashSet<PmpPerformanceIndicator>();
        }

        public int PmpDataCollectionFrequencyCode { get; set; }
        public string PmpDataCollectionFrequencyDesc { get; set; }

        public virtual ICollection<PmpPerformanceIndicator> PmpPerformanceIndicator { get; set; }
    }
}
