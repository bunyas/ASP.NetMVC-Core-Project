using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AProductLabCategory1
    {
        public int ProductCategoryCode { get; set; }
        public int? ProductCode { get; set; }
        public int? Category2Code { get; set; }
        public int? Category3Code { get; set; }

        public virtual ALabCategory3 Category3CodeNavigation { get; set; }
    }
}
