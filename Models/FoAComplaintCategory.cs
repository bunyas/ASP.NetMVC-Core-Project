using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoAComplaintCategory
    {
        public FoAComplaintCategory()
        {
            FoComplaint = new HashSet<FoComplaint>();
        }

        public int ComplaintCategoryCode { get; set; }
        public string ComplaintCategoryDesc { get; set; }

        public virtual ICollection<FoComplaint> FoComplaint { get; set; }
    }
}
