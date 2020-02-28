using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AOrderStatus
    {
        public AOrderStatus()
        {
            OrderHeader = new HashSet<OrderHeader>();
            OrderHivRapidTestKitHeader = new HashSet<OrderHivRapidTestKitHeader>();
            OrderLabCustomHeader = new HashSet<OrderLabCustomHeader>();
            OrderLabHeader = new HashSet<OrderLabHeader>();
            OrderMaultHeader = new HashSet<OrderMaultHeader>();
            OrderOiStiHeader = new HashSet<OrderOiStiHeader>();
            OrderPrepHeader = new HashSet<OrderPrepHeader>();
            OrderRutfHeader = new HashSet<OrderRutfHeader>();
            OrderSmcSlmHeader = new HashSet<OrderSmcSlmHeader>();
            OrderTbHeader = new HashSet<OrderTbHeader>();
            OrderViralLoadReagentsHeader = new HashSet<OrderViralLoadReagentsHeader>();
        }

        public int StatusId { get; set; }
        public string Status { get; set; }

        public virtual ICollection<OrderHeader> OrderHeader { get; set; }
        public virtual ICollection<OrderHivRapidTestKitHeader> OrderHivRapidTestKitHeader { get; set; }
        public virtual ICollection<OrderLabCustomHeader> OrderLabCustomHeader { get; set; }
        public virtual ICollection<OrderLabHeader> OrderLabHeader { get; set; }
        public virtual ICollection<OrderMaultHeader> OrderMaultHeader { get; set; }
        public virtual ICollection<OrderOiStiHeader> OrderOiStiHeader { get; set; }
        public virtual ICollection<OrderPrepHeader> OrderPrepHeader { get; set; }
        public virtual ICollection<OrderRutfHeader> OrderRutfHeader { get; set; }
        public virtual ICollection<OrderSmcSlmHeader> OrderSmcSlmHeader { get; set; }
        public virtual ICollection<OrderTbHeader> OrderTbHeader { get; set; }
        public virtual ICollection<OrderViralLoadReagentsHeader> OrderViralLoadReagentsHeader { get; set; }
    }
}
