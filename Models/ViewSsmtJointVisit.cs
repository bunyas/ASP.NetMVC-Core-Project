using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewSsmtJointVisit
    {
        public int JointVisitCode { get; set; }
        public string JointVisitDesc { get; set; }
        public bool? Visited { get; set; }
        public string Comments { get; set; }
    }
}
