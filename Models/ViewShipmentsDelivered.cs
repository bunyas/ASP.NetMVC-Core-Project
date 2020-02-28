using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewShipmentsDelivered
    {
        public int? OutstandingQuantity { get; set; }
        public DateTime OrderDueDate { get; set; }
        public int? ExpectedShipment { get; set; }
        public int? QuantityRecievedMaul { get; set; }
        public DateTime? DateClearedCustoms { get; set; }
    }
}
