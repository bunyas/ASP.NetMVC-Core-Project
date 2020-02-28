using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SapEmergencySiteOrderDocumetLines
    {
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DatePrepared { get; set; }
        public int OrderCategory { get; set; }
        public int ItemCode { get; set; }
        public DateTime AddedDate { get; set; }
        public bool? CurrentRecord { get; set; }
        public bool? RecordReadBySap { get; set; }
        public string DocNum { get; set; }
        public int? QuantityAllocated { get; set; }
        public int? QuantityOrdered { get; set; }
        public bool? CurrentRecordOnSap { get; set; }
        public bool? EmergencyOrder { get; set; }

        public virtual SapEmergencySiteOrderHeader SapEmergencySiteOrderHeader { get; set; }
    }
}
