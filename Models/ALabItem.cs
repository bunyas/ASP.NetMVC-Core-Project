using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ALabItem
    {
        public int ItemCode { get; set; }
        public int? GroupCode { get; set; }
        public double? GroupChild1 { get; set; }
        public double? GroupChild2 { get; set; }
        public string ItemDescsription { get; set; }
        public string Uom { get; set; }
        public double? UnitPrice { get; set; }
        public int? ItemOrder { get; set; }

        public virtual ALabGroupChild1 GroupC { get; set; }
        public virtual ALabGroupChild2 GroupCNavigation { get; set; }
        public virtual ALabGroup1 GroupCodeNavigation { get; set; }
    }
}
