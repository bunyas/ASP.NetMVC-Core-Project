using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssModule
    {
        public ChssModule()
        {
            ChssComments = new HashSet<ChssComments>();
            ChssFeedBackReport = new HashSet<ChssFeedBackReport>();
            ChssModuleSector = new HashSet<ChssModuleSector>();
            ChssQuestionGuid = new HashSet<ChssQuestionGuid>();
        }

        public int ModuleId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ChssComments> ChssComments { get; set; }
        public virtual ICollection<ChssFeedBackReport> ChssFeedBackReport { get; set; }
        public virtual ICollection<ChssModuleSector> ChssModuleSector { get; set; }
        public virtual ICollection<ChssQuestionGuid> ChssQuestionGuid { get; set; }
    }
}
