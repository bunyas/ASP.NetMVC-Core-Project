using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewDistOperatorPermit
    {
        public string DriverPermitNumber { get; set; }
        public string Name { get; set; }
        public bool? ValidPermit { get; set; }
        public string OperatorId { get; set; }
        public int? PermitCategory { get; set; }
        public DateTime? PermitDateOfIssue { get; set; }
        public DateTime? PermitExpiryDate { get; set; }
        public int? JobTitle { get; set; }
    }
}
