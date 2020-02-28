using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewOrderLabAllocation
    {
        public int ItemCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool? EmergencyOrder { get; set; }
        public string Status { get; set; }
        public string OrderType { get; set; }
        public int? ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int StatusId { get; set; }
        public int OrderTypeId { get; set; }
        public string LabCat2Desc { get; set; }
        public string LabCat1Desc { get; set; }
    }
}
