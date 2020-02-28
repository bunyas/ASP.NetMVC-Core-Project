using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ProcTrackerPfi
    {
        public string PfiNo { get; set; }
        public string PurchaseOrderNo { get; set; }
        public int SupplierId { get; set; }
        public DateTime? DateRecievedPfi { get; set; }
        public DateTime? DateForwardedNda { get; set; }
        public DateTime? DateRecievedNda { get; set; }
        public double? PfiValue { get; set; }
        public double? PfiTotalCif { get; set; }
        public double? PfiTotalFob { get; set; }

        public virtual ProcTrackerOrder ProcTrackerOrder { get; set; }
    }
}
