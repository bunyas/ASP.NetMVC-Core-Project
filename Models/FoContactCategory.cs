using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoContactCategory
    {
        public FoContactCategory()
        {
            FoComplaint = new HashSet<FoComplaint>();
            FoContactPerson = new HashSet<FoContactPerson>();
        }

        public int CategoryId { get; set; }
        public string CategoryDesc { get; set; }

        public virtual ICollection<FoComplaint> FoComplaint { get; set; }
        public virtual ICollection<FoContactPerson> FoContactPerson { get; set; }
    }
}
