using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AOrderType
    {
        public AOrderType()
        {
            OrderHeader = new HashSet<OrderHeader>();
            OrderHivRapidTestKitHeader = new HashSet<OrderHivRapidTestKitHeader>();
            OrderLabHeader = new HashSet<OrderLabHeader>();
            OrderOiStiHeader = new HashSet<OrderOiStiHeader>();
            OrderPrepHeader = new HashSet<OrderPrepHeader>();
            OrderRutfHeader = new HashSet<OrderRutfHeader>();
            OrderSmcSlmHeader = new HashSet<OrderSmcSlmHeader>();
            OrderTbHeader = new HashSet<OrderTbHeader>();
            OrderViralLoadReagentsHeader = new HashSet<OrderViralLoadReagentsHeader>();
        }

        public int OrderTypeId { get; set; }
        public string OrderType { get; set; }

        public virtual ICollection<OrderHeader> OrderHeader { get; set; }
        public virtual ICollection<OrderHivRapidTestKitHeader> OrderHivRapidTestKitHeader { get; set; }
        public virtual ICollection<OrderLabHeader> OrderLabHeader { get; set; }
        public virtual ICollection<OrderOiStiHeader> OrderOiStiHeader { get; set; }
        public virtual ICollection<OrderPrepHeader> OrderPrepHeader { get; set; }
        public virtual ICollection<OrderRutfHeader> OrderRutfHeader { get; set; }
        public virtual ICollection<OrderSmcSlmHeader> OrderSmcSlmHeader { get; set; }
        public virtual ICollection<OrderTbHeader> OrderTbHeader { get; set; }
        public virtual ICollection<OrderViralLoadReagentsHeader> OrderViralLoadReagentsHeader { get; set; }
    }
}
