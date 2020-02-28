using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewPmpTotalShipments
    {
        public DateTime OrderDueDate { get; set; }
        public DateTime? DateArrivalEntebbe { get; set; }
        public string PurchaseOrderNo { get; set; }
        public DateTime? DateClearedCustoms { get; set; }
    }
}
