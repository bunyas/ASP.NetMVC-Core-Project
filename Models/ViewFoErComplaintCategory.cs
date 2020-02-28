using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewFoErComplaintCategory
    {
        public int? NoOfComplaints { get; set; }
        public int ERegComplaintCode { get; set; }
        public string ComplaintCategoryDesc { get; set; }
        public DateTime? ERegDateRecieved { get; set; }
    }
}
