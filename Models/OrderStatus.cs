using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class OrderStatus
    {
        public int Id { get; set; }
        public int? StatusId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public DateTime? DispatchedDate { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public bool? ReadByMascis { get; set; }
    }
}
