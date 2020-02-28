using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewXPmpProcCorrectlyFilledPos
    {
        public double? AwardQuantityOrdered { get; set; }
        public double? QuantityRecievedMaul { get; set; }
        public int? OrderYear { get; set; }
        public int? OrderQuater { get; set; }
        public string ReferenceNo { get; set; }
        public DateTime? AwardNewDueDate { get; set; }
        public DateTime? AwardExpectedDateDelivery { get; set; }
    }
}
