using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ASmcItem
    {
        public int ItemCode { get; set; }
        public int CategoryCode { get; set; }
        public string ItemName { get; set; }
        public string Uom { get; set; }

        public virtual ASmcCategory CategoryCodeNavigation { get; set; }
    }
}
