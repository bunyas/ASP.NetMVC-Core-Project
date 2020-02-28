using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SapExportDocumentLines
    {
        public string OrderNumber { get; set; }
        public int ItemCode { get; set; }
        public bool? CurrentRecord { get; set; }
        public bool? RecordReadBySap { get; set; }
        public string DocNum { get; set; }
        public int? QuantityAllocated { get; set; }
        public int? QuantityOrdered { get; set; }
        public bool? CurrentRecordOnSap { get; set; }
        public DateTime? AddedDate { get; set; }
        public string AddedBy { get; set; }

        public virtual SapExportHeader OrderNumberNavigation { get; set; }
    }
}
